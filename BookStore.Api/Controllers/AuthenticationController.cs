using BookStore.Application.Services.Authentication;
using BookStore.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers;

[ApiController]
[Route("api/auth/[action]")]
public class AuthenticationController(IAuthService auth) : ControllerBase
{
    private readonly IAuthService _auth = auth;

    [HttpPost]
    public IActionResult Register(RegisterRequest request)
    {
        var authResult = _auth.Register(
            request.FirstName,
            request.LastName,
            request.Email,
            request.Password);

        var response = new AuthenticationResponse
        {
            Id = authResult.Id,
            FirstName = authResult.FirstName,
            LastName = authResult.LastName,
            Email = authResult.Email,
            Token = authResult.Token
        };

        return Ok(response);
    }

    [HttpPost]
    public IActionResult Login(LoginRequest request)
    {
        var authResult = _auth.Login(
            request.Email,
            request.Password);

        var response = new AuthenticationResponse
        {
            Id = authResult.Id,
            FirstName = authResult.FirstName,
            LastName = authResult.LastName,
            Email = authResult.Email,
            Token = authResult.Token
        };

        return Ok(response);
    }
}