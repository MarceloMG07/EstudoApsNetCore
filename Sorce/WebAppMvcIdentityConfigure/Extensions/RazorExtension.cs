using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Razor;
using WebAppMvcIdentityConfigure.Helpers;

namespace WebAppMvcIdentityConfigure.Extensions
{
    public static class RazorExtension
    {
        public static bool IfClaim(this RazorPage page, string claimName, string claimValue)
        {
            return CustomAuthorizationHelper.ValidarClaimsUsuario(page.Context, claimName, claimValue);
        }
        public static string IfClaimShow(this RazorPage page, string claimName, string claimValue)
        {
            return CustomAuthorizationHelper.ValidarClaimsUsuario(page.Context, claimName, claimValue) ? "" : "disabled";
        }
        public static IHtmlContent? IfClaimShow(this IHtmlContent page, HttpContext context, string claimName, string claimValue)
        {
            return CustomAuthorizationHelper.ValidarClaimsUsuario(context, claimName, claimValue) ? page : null;
        }
    }
}
