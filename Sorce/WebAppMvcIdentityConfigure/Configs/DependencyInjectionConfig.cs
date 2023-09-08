using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebAppMvcIdentityConfigure.Areas.Identity.Data;
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
        public static IServiceCollection AddIdentityConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            // Adicionando suporte ao contexto do Identity via EF
            var connectionString = configuration.GetConnectionString("WebAppMvcIdentityContextConnection") ?? throw new InvalidOperationException("Connection string 'WebAppMvcIdentityContextConnection' not found.");
            services.AddDbContext<WebAppMvcIdentityContext>(options => options.UseMySQL(connectionString));

            // Adicionando configuração padrão do Identity
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddDefaultUI()
                .AddEntityFrameworkStores<WebAppMvcIdentityContext>();

            return services;
        }
    }
}
