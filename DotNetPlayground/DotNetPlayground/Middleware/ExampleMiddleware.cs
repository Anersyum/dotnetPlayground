using System.IO.Pipelines;
using System.Text.Json;

namespace DotNetPlayground.Middleware;

public sealed class ExampleMiddleware
{
    private readonly ILogger<ExampleMiddleware> _logger;
    private readonly RequestDelegate _next;

    public ExampleMiddleware(ILogger<ExampleMiddleware> logger, RequestDelegate next)
    {
        _logger = logger;
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        _logger.LogInformation("Aktivarn middleware!");

        var url = context.Request.Headers["Origin"];

        if (url.Contains("7131"))
        {
            throw new Exception("Url ne valja!");
        }
        
        await _next.Invoke(context);
    }
}
