using Microsoft.AspNetCore.Mvc;

namespace Bazon.Backend.Api.Controllers;

[ApiController]
[Route("api/v0/[controller]")]
public class AuthenticationController : ControllerBase
{
    private readonly ILogger<AuthenticationController> _logger;

    public AuthenticationController(ILogger<AuthenticationController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public async Task<IActionResult> Login(string email, string hashedPassword)
    {
        return Ok();
    }
}