namespace BookStore.Application.Services.Authentication;

public class AuthService : IAuthService
{
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
        return new AuthResult
        {
            Id = Guid.NewGuid(),
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Token = "Token"
        };
    }
}