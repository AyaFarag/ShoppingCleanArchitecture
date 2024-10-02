using Microsoft.AspNetCore.Authorization;

namespace Shopping.Application.Authorization
{
    public class PermissionHandler : AuthorizationHandler<PermissionRequirement>
    {
        private readonly IServiceProvider _serviceProvider;
        public PermissionHandler(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionRequirement requirement)
        {
            // Create a scope to resolve the IRoleService
            //using (var scope = _serviceProvider.CreateScope())
            //{
            //    var roleService = scope.ServiceProvider.GetRequiredService<IRoleService>();

            //    // Use roleService for permission handling logic
            //    var hasPermission = await roleService.HasPermissionAsync(context.User, requirement.Permission);

            //    if (hasPermission)
            //    {
            //        context.Succeed(requirement);
            //    }
            //}
        }
    }
}
