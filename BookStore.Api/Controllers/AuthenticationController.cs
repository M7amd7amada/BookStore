using BookStore.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers;

[ApiController]
[Route("api/auth/[action]")]
public class AuthenticationController : ControllerBase
{
    [HttpPost]
    public IActionResult Register(RegisterRequest request)
    {
        return Ok(request);
    }

    [HttpPost]
    public IActionResult Login(LoginRequest request)
    {
        return Ok(request);
    }
}