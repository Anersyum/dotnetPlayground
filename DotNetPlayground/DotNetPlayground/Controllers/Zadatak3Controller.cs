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

    [HttpPost("/user")]
    public async Task<IActionResult> UserCreateAction(User user)
    {
        return CreatedAtAction(nameof(UserCreateAction), user);
    }

    [HttpPut("/user/{userId}")]
    public async Task<IActionResult> UserEditAction(int userId)
    {
        return Ok($"Update korisnika sa ID {userId}");
    }

    [HttpDelete("/user/{userId}")]
    public async Task<IActionResult> UserDeleteAction(int userId)
    {
        return Ok($"Obrisan korisnik sa ID {userId}");
    }

    [HttpGet("/user/{userId}")]
    public async Task<IActionResult> UsergetbyIdAction(int userId)
    {
        return Ok(new
        {
            UserId = userId,
            FirstName = "Meho",
            LastName = "Mješalica"
        });
    }
}
