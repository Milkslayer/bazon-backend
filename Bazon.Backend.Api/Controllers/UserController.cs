using Bazon.Backend.Api.Models;
using Bazon.Backend.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bazon.Backend.Api.Controllers;

[ApiController]
[Route("api/v0/[controller]")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private readonly IUserService _userService;

    public UserController(ILogger<UserController> logger, IUserService userService)
    {
        _logger = logger;
        _userService = userService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser(UserCreateDto userCreateDto)
    {
        var result = await _userService.CreateUser(userCreateDto);
        return Ok(result);
    }
    
    [HttpPatch]
    public async Task<IActionResult> UpdateUser(UserUpdateDto userUpdateDto)
    {
        var result = await _userService.UpdateUser(userUpdateDto);
        return Ok(result);
    }
    
    [HttpPost]
    public async Task<IActionResult> DeleteUser(int userId)
    {
        var result = await _userService.DeleteUser(userId);
        return Ok(result);
    }
}