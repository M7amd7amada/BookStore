using BookStore.Application.Common.Interfaces.Authentication;

namespace BookStore.Application.Services.Authentication;

public class AuthService(IJwtTokenGenerator jwtTokenGenerator) : IAuthService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator = jwtTokenGenerator;

    public AuthResult Login(string email, string password)
    {
        return new AuthResult
        {
            Id = Guid.NewGuid(),
            FirstName = "firstname",
            LastName = "lastname",
            Email = email,
            Token = "Token"
        };
    }

    public AuthResult Register(string firstName, string lastName, string email, string password)
    {
        Guid id = Guid.NewGuid();
        var token = _jwtTokenGenerator.GenerateToken(id, firstName, lastName);

        return new AuthResult
        {
            Id = Guid.NewGuid(),
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Token = token
        };
    }
}