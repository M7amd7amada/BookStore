namespace BookStore.Application.Services.Authentication;

public interface IAuthService
{
    public AuthResult Register(
        string firstName,
        string lastName,
        string email,
        string password);
    public AuthResult Login(string email, string password);
}