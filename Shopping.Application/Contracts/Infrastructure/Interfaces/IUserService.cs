

using Shopping.Application.DTOs;
using Shopping.Domain.Entities;

namespace Shopping.Application.Contracts.Infrastructure.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(int id);
        Task<User> CreateUserAsync(User user);
        Task<User> UpdateUserAsync(User user);
        Task DeleteUserAsync(int id);
        Task AssignRoleToUserAsync(int userId, int roleId);
    }
}
