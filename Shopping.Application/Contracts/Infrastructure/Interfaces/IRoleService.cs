using Shopping.Application.DTOs;
using Shopping.Domain.Entities;


namespace Shopping.Application.Contracts.Infrastructure.Interfaces
{
    public interface IRoleService
    {
        Task<RoleDto> GetRoleByIdAsync(int roleId);
        Task<List<RoleDto>> GetAllRolesAsync();
        Task CreateRoleAsync(RoleDto roleDto);
        Task AssignPermissionToRole(int roleId, string permission);
        Task<Role> GetRoleWithPermissionsAsync(int roleId);
    }
}
