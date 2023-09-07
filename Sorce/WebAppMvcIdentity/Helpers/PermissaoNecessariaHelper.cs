using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAppMvcIdentity.Helpers
{
    public class PermissaoNecessariaHelper : IAuthorizationRequirement
    {
        public string Permissao { get; }

        public PermissaoNecessariaHelper(string permissao)
        {
            Permissao = permissao;
        }
    }

    public class PermissaoNecessariaHelperHandler : AuthorizationHandler<PermissaoNecessariaHelper>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissaoNecessariaHelper requirement)
        {
            //throw new NotImplementedException();
            if (context.User.HasClaim(c => c.Type == "Permissao" && c.Value.Contains(requirement.Permissao)))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
