using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BookStore.Application.Common.Interfaces.Authentication;
using BookStore.Application.Common.Interfaces.Services;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace BookStore.Infrastructure.Authentication;

public class JwtTokenGenerator : IJwtTokenGenerator
{
    private readonly IDateTimeProvider _dateTimeProvider;
    private readonly JwtSettings _jwtSettings;

    public JwtTokenGenerator(IDateTimeProvider dateTimeProvider, IOptions<JwtSettings> jwtOptions)
    {
        _dateTimeProvider = dateTimeProvider;
        _jwtSettings = jwtOptions.Value;
    }

    public string GenerateToken(Guid id, string firstName, string lastName)
    {
        var securityToken = new JwtSecurityToken(
            issuer: _jwtSettings.Issuer,
            expires: _dateTimeProvider.Now.AddMinutes(_jwtSettings.ExpiryMinutes),
            audience: _jwtSettings.Audience,
            claims: GetClaims(id, firstName, lastName),
            signingCredentials: GetSigningCredentials(_jwtSettings.Secret)
        );

        return new JwtSecurityTokenHandler().WriteToken(securityToken);
    }

    private static SigningCredentials GetSigningCredentials(string secretKey)
    {
        return new(
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)),
            SecurityAlgorithms.HmacSha256);
    }

    private static Claim[] GetClaims(Guid id, string firstName, string lastName)
    {
        return
        [
            new Claim(JwtRegisteredClaimNames.Sub, id.ToString()),
            new Claim(JwtRegisteredClaimNames.GivenName, firstName),
            new Claim(JwtRegisteredClaimNames.FamilyName, lastName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        ];
    }
}