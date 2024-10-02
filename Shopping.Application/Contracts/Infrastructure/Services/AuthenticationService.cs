using Shopping.Application.Contracts.Infrastructure.Interfaces;
using Shopping.Application.Contracts.Infrastructure.Interfaces.Repository;
using Shopping.Domain.Entities;



namespace Shopping.Application.Contracts.Infrastructure.Services
{
    internal class AuthenticationService : IAuthenticationService
    {
        private readonly IAuthRepository? _authRepository;
        private readonly IJwtTokenService? _jwtTokenService;

        public async Task<string> login(string username, string password)
        {
            var user = await _authRepository.GetUserByUsernameAndPasswordAsync(username , password);
            if (user == null)
            {
                throw new Exception("Invalid credentials");
            }

            return _jwtTokenService.GenerateJwtToken(user);
        }

        public Task<string> logout()
        {
            throw new NotImplementedException();
        }

        public Task<string> register()
        {
            throw new NotImplementedException();
        }

      
    }
}
