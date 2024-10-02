using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shopping.Application.Contracts.Infrastructure.Interfaces;
using Shopping.Application.DTOs;

namespace Shopping.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductDto dto)
        {
            await _productService.CreateProductAsync(dto);
            return Ok("Product created successfully");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, ProductDto dto)
        {
            await _productService.UpdateProductAsync(id, dto);
            return Ok("Product updated successfully");
        }
    }
}
