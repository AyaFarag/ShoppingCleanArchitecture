using Shopping.Application.Contracts.Infrastructure.Interfaces.Repository;
using Shopping.Domain.Entities;
using Shopping.Infrastructure.Presistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Infrastructure.Repository.Services
{
    public class ProductRepository : Repository<Product> , IProductRepository
    {

        public ProductRepository(DBContextApplication context) : base(context)
        {
        }
    }

}
