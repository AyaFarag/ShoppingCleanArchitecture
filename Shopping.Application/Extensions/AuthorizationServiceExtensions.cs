using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Shopping.Application.Authorization;


namespace Shopping.Application.Extensions
{
    public static class AuthorizationServiceExtensions
    {
        public static IServiceCollection AddCustomAuthorization(this IServiceCollection services)
        {
            // Add Authorization and define policies
            services.AddAuthorizationCore(options =>
            {
                options.AddCustomAuthorizationPolicies();  // Call the custom method for defining policies
            });

            // Register custom permission handler
            services.AddSingleton<IAuthorizationHandler, PermissionHandler>();

            return services;
        }
    }
}
