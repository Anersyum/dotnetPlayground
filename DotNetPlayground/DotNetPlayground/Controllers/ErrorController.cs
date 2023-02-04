using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace DotNetPlayground.Controllers;

[ApiExplorerSettings(IgnoreApi = true)]
[Route("/error")]
[ApiController]
public sealed class ErrorController : ControllerBase
{
    public IActionResult HandleException()
    {
        var exceptionFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

        if (exceptionFeature is not null)
        {
            var exceptionMessage = exceptionFeature.Error.InnerException?.Message ?? exceptionFeature.Error.Message;

            return BadRequest(exceptionMessage);
        }

        return Problem("Something went wrong");
    }
}
