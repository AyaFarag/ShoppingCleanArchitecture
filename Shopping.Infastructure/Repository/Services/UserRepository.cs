using Shopping.Domain.Entities;
using Shopping.Infrastructure.Presistance;
using Shopping.Application.Contracts.Infrastructure.Interfaces.Repository;


namespace Shopping.Infrastructure.Repository.Services
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DBContextApplication context) : base(context)
        {
        }

        // User CRUD Generic

        public Task AssignRoleToUserAsync(int userId, int roleId)
        {
            throw new NotImplementedException();
        }
    }
}
