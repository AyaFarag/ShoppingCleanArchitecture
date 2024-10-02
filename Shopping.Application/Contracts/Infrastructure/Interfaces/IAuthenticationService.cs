using Shopping.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Application.Contracts.Infrastructure.Interfaces
{
    public interface IAuthenticationService
    {
        Task<string> login(string username, string password);

        Task<string> register();

        Task<string> logout();

    }
}
