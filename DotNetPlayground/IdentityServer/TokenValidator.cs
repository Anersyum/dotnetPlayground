using IdentityServer4.Models;
using IdentityServer4.Validation;
using System.Security.Claims;

namespace IdentityServer;

public class TokenValidator : ICustomTokenRequestValidator
{
    public Task ValidateAsync(CustomTokenRequestValidationContext context)
    {
        var testValue = context.Result.ValidatedRequest.Raw.Get("test");

        if (!string.IsNullOrEmpty(testValue))
        {
            context.Result.ValidatedRequest.ClientClaims = new List<Claim> { new("test", testValue!) };
        }

        return Task.CompletedTask;
    }
}
