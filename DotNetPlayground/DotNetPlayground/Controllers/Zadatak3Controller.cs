using DotNetPlayground.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DotNetPlayground.Controllers;

[Route("api/[controller]")]
[ApiController]
public class Zadatak3Controller : ControllerBase
{
    [HttpGet("/users")]
    public async Task<IActionResult> GetAllUsersAction([FromServices] IUserRepository userRepository)
    {
        var users = await userRepository.GetAllUsers();

        return Ok(users);
    }
}
