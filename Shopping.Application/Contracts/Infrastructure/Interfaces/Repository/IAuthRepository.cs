using Shopping.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Application.Contracts.Infrastructure.Interfaces.Repository
{
    public interface IAuthRepository 
    {
        Task<User> GetUserByUsernameAndPasswordAsync(string username ,string password);
    }
}
