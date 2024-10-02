using Shopping.Domain.Entities;

namespace Shopping.Application.Contracts.Infrastructure.Interfaces
{
    public interface IPermissionService
    {
        Task<List<Permission>> GetPermissionsForModuleAsync(int moduleId);
    }
}
