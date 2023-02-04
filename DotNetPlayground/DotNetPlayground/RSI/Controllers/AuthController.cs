using DotNetPlayground.Data;
using DotNetPlayground.RSI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace DotNetPlayground.RSI.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class AuthController : ControllerBase
{
    private readonly IMemoryCache _memoryCache;

    public AuthController(IMemoryCache memoryCache)
    {
        _memoryCache = memoryCache;
    }

    [HttpPost("checkIfLoggedIn")]
    public IActionResult IsLoggedInAction(TokenViewModel token)
    {
        if (token is null || token.Token is null)
        {
            return BadRequest(false);
        }

        var existingToken = _memoryCache.Get(token.Token);

        if (existingToken is null) 
        {
            return Unauthorized(false);
        }

        return Ok(true);
    }

    [HttpPost("prijava")]
    public async Task<IActionResult> PrijavaAction([FromServices] Baza baza, LoginViewModel loginData)
    {
        var osoblje = await baza.Osoblje
            .FirstOrDefaultAsync(o => o.Password== loginData.Password && o.Username == loginData.Username);

        if (osoblje is null)
        {
            return NotFound();
        }

        string token = Convert.ToBase64String(Guid.NewGuid().ToByteArray());

        _memoryCache.Set(token, true, DateTime.Now.AddMinutes(10));

        return Ok(new
        {
            Token = token
        });
    }

}
