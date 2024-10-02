using Shopping.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Application.Contracts.Infrastructure.Interfaces.Repository
{
    public interface IUserRepository : IRepository<User>
    {
        // Additional methods specific to user if needed
        Task AssignRoleToUserAsync(int userId , int roleId);
    }
}
