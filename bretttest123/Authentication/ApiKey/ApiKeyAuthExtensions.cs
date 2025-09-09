using Microsoft.AspNetCore.Authentication;

namespace bretttest123.Authentication;

public static class ApiKeyAuthExtensions
{
    public const string Scheme = "ApiKey";

    public static AuthenticationBuilder AddApiKeyAuthentication(this AuthenticationBuilder builder, IConfiguration config)
    {
        return builder.AddScheme<ApiKeyAuthenticationSchemeOptions, ApiKeyAuthenticationHandler>(Scheme, Scheme, options =>
        {
            config.GetSection(Scheme).Bind(options);
        });
    }
}
