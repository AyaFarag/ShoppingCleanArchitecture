using Microsoft.AspNetCore.Authorization;
using Shopping.Application.Authorization;


namespace Shopping.Application.Extensions
{
    public static class CustomAuthorizationPolicyProvider
    {
        public static void AddCustomAuthorizationPolicies(this AuthorizationOptions options)
        {
            options.AddPolicy("CanReadUsers", policy => policy.Requirements.Add(new PermissionRequirement("Read")));
            options.AddPolicy("CanWriteUsers", policy => policy.Requirements.Add(new PermissionRequirement("Write")));

            // Add more policies as needed
        }
    }
}
