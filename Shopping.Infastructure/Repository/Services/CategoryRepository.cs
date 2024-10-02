using Shopping.Domain.Entities;
using Shopping.Infrastructure.Presistance;
using Shopping.Application.Contracts.Infrastructure.Interfaces.Repository;

namespace Shopping.Infrastructure.Repository.Services
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(DBContextApplication context) : base(context)
        {
        }

       // CRUD repository Generic
    }
}
