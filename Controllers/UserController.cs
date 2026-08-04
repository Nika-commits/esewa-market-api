using esewa_market.Data.Dto.Request;
using esewa_market.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace esewa_market.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController(
    IUserService userService
    ) : ControllerBase
{
    [HttpPost]
    public async  Task<IActionResult> CreateUser(CreateUserRequest user)
    {
        var result = await userService.CreateUser(user);
        return Ok(result);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetUserById(int id)
    {
        var result = await userService.GetUserById(id);
        return Ok(result);
    }
}