using Microsoft.AspNetCore.Authorization;
using WebAppMvcIdentityConfigure.Helpers;

namespace WebAppMvcIdentityConfigure.Configs
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddSingleton<IAuthorizationHandler, PermissaoNecessariaHelperHandler>();
            
            return services;
        }
    }
}
