using WebAppMvcIdentityConfigure.Helpers;

namespace WebAppMvcIdentityConfigure.Configs
{
    public static class IdentityConfig
    {
        public static IServiceCollection AddAuthorizationConfig(this IServiceCollection services)
        {
            services.AddAuthorization(options =>
            {
                options.AddPolicy("PodeExcluir", policy => policy.RequireClaim("PodeExcluir"));

                options.AddPolicy("PodeLer", policy => policy.Requirements.Add(new PermissaoNecessariaHelper("PodeLer")));
                options.AddPolicy("PodeEscrever", policy => policy.Requirements.Add(new PermissaoNecessariaHelper("PodeEscrever")));
                //options.AddPolicy("PodeEscrever", policy => policy.Requirements.Add(new PermissaoNecessaria("PodeEscrever")));
            });

            return services;
        }
    }
}
