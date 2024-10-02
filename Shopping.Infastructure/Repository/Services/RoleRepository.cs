using Microsoft.EntityFrameworkCore;
using Shopping.Application.Contracts.Infrastructure.Interfaces.Repository;
using Shopping.Domain.Entities;
using Shopping.Infrastructure.Presistance;


namespace Shopping.Infrastructure.Repository.Services
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        
        public RoleRepository(DBContextApplication context) : base(context)
        {
        }

        public Task AssignPermissionToRoleAsync(int roleId, string permission)
        {
            throw new NotImplementedException();
        }

        public Task<Role> GetRoleWithPermissionsAsync(int roleId)
        {
            throw new NotImplementedException();
        }
    }
}
