using Shopping.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Application.Contracts.Infrastructure.Interfaces.Repository
{
    public interface IRoleRepository : IRepository<Role>
    {
        Task AssignPermissionToRoleAsync(int roleId, string permission);

        Task<Role> GetRoleWithPermissionsAsync(int roleId);
    }
}
