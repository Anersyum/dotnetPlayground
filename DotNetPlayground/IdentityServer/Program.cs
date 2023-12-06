using IdentityModel;
using IdentityServer;
using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Services;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddTransient<IProfileService, IdentityProfile>();

builder.Services.AddIdentityServer()
    .AddDeveloperSigningCredential()
    .AddCustomTokenRequestValidator<TokenValidator>()
    .AddInMemoryIdentityResources(Config.GetIdentityResources)
    .AddInMemoryApiResources(Config.GetApiResources)
    .AddInMemoryApiScopes(Config.ApiScopes)
    .AddInMemoryClients(Config.Clients)
    .AddProfileService<IdentityProfile>();

var app = builder.Build();

app.UseIdentityServer();

app.Run();

public static class Config
{
    public static IEnumerable<IdentityResource> GetIdentityResources => new List<IdentityResource>
    {
        new("openid", "userIdentifier",new[] { "sub" }),
        new("profile", "someData", new[] { "name" })
    };

    public static IEnumerable<ApiResource> GetApiResources => new List<ApiResource>
    {
        new("api1")
        {
            Scopes =
            {
                "api1"
            },
            UserClaims =
            {
                JwtClaimTypes.Subject,
                JwtClaimTypes.Email
            },
            ShowInDiscoveryDocument = true
        }
    };

    public static IEnumerable<ApiScope> ApiScopes => new List<ApiScope>
    {
        new ApiScope("api1", "My API" )
    };

    public static IEnumerable<Client> Clients =>
    new List<Client>
    {
        new Client
        {
            ClientId = "client",

            // no interactive user, use the clientid/secret for authentication
            AllowedGrantTypes = GrantTypes.ClientCredentials,

            // secret for authentication
            ClientSecrets =
            {
                new Secret("secret".ToSha256())
            },

            // scopes that client has access to
            AllowedScopes = { "api1", "profile", "openid" },

            AlwaysSendClientClaims = true,
            ClientClaimsPrefix = string.Empty
        }
    };
}