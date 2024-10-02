using Shopping.Application.Contracts.Infrastructure.Interfaces.Repository;
using Shopping.Infrastructure.Presistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Infrastructure.Repository.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DBContextApplication _context;
        private IProductRepository _products;
        private ICategoryRepository _categories;

        public UnitOfWork(DBContextApplication context)
        {
            _context = context;
        }

        public IProductRepository Products => _products ??= new ProductRepository(_context);
        public ICategoryRepository Categories => _categories ??= new CategoryRepository(_context);

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
