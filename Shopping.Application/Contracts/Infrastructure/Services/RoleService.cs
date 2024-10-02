using Shopping.Application.Contracts.Infrastructure.Interfaces;
using Shopping.Application.Contracts.Infrastructure.Interfaces.Repository;
using Shopping.Application.DTOs;
using Shopping.Domain.Entities;



namespace Shopping.Application.Contracts.Infrastructure.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task<List<RoleDto>> GetAllRolesAsync()
        {
            var roles = await _roleRepository.GetAllAsync();
            return new List<RoleDto>();
        }

        public async Task CreateRoleAsync(RoleDto roleDto)
        {
            // Logic to create new role
            var role = new Role() {  };
            await _roleRepository.AddAsync(role);

        }

        public async Task AssignPermissionToRole(int roleId, string permission)
        {
            // Logic to assign permission to role
           await _roleRepository.AssignPermissionToRoleAsync(default(int), permission);
        }


        public async Task<Role> GetRoleWithPermissionsAsync(int roleId)
        {
            return await _roleRepository.GetRoleWithPermissionsAsync(roleId);
        }

        public async Task<RoleDto> GetRoleByIdAsync(int roleId)
        {
            await _roleRepository.GetByIdAsync(roleId);
            return new RoleDto() { };
        }
    }
}
