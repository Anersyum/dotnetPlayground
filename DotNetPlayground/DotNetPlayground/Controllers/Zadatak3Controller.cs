using DotNetPlayground.Interfaces;
using DotNetPlayground.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetPlayground.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class Zadatak3Controller : ControllerBase
{
    [HttpGet("/users")]
    public async Task<IActionResult> GetAllUsersAction([FromServices] IUserRepository userRepository)
    {
        var users = await userRepository.GetAllUsers();

        return Ok(users);
    }

    [HttpPost("/user/create")]
    public async Task<IActionResult> UserCreateAction(User user)
    {
        return CreatedAtAction(nameof(UserCreateAction), user);
    }
}
