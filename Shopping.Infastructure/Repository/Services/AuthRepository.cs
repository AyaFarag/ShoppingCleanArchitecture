using Shopping.Domain.Entities;
using Shopping.Application.Contracts.Infrastructure.Interfaces.Repository;


namespace Shopping.Infrastructure.Repository.Services
{
    public class AuthRepository : IAuthRepository
    {
        public Task<User> GetUserByUsernameAndPasswordAsync(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
