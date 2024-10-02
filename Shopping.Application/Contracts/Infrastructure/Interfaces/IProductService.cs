using Shopping.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Application.Contracts.Infrastructure.Interfaces
{
    public interface IProductService
    {
        Task CreateProductAsync(ProductDto dto);
        Task UpdateProductAsync(int id, ProductDto dto);
        Task<ProductDto> GetProductByIdAsync(int id);
        Task<IEnumerable<ProductDto>> GetAllProductsAsync();
        Task DeleteProductAsync(int id);
    }
}
