using Microsoft.EntityFrameworkCore;
using Shopping.Domain.Entities;
using Shopping.Infrastructure.Presistance;
using Shopping.Application.Contracts.Infrastructure.Interfaces.Repository;


namespace Shopping.Infrastructure.Repository.Services
{
    public class PermissionRepository : IPermissionRepository
    {
        private readonly DBContextApplication _context;

        public PermissionRepository(DBContextApplication context)
        {
            _context = context;
        }
        public async Task<List<Permission>> GetPermissionsForModuleAsync(int moduleId)
        {
            return await _context.Permissions
                             .Where(p => p.ModuleId == moduleId)
                             .ToListAsync();
        }
    }
}
