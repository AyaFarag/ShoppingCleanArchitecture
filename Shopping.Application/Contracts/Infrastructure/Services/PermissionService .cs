
using Shopping.Application.Contracts.Infrastructure.Interfaces;
using Shopping.Application.Contracts.Infrastructure.Interfaces.Repository;
using Shopping.Domain.Entities;



namespace Shopping.Application.Contracts.Infrastructure.Services
{
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionRepository _permissionRepository;
        public PermissionService(IPermissionRepository permissionRepository) 
        {
            _permissionRepository = permissionRepository;
        }
        public async Task<List<Permission>> GetPermissionsForModuleAsync(int moduleId)
        {
            return await _permissionRepository.GetPermissionsForModuleAsync(moduleId);
        }
    }
}
