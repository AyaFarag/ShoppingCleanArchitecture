using FluentValidation;
using Shopping.Application.Contracts.Infrastructure.Interfaces.Repository;
using Shopping.Application.DTOs;
using Shopping.Domain.Entities;


namespace Shopping.Application.Behaviors.Validation
{
    public class ProductValidator : AbstractValidator<ProductDto>
    {

        private readonly ICategoryRepository _categoryRepository;

        public ProductValidator(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;

            RuleFor(p=>p.Name).NotEmpty().WithMessage("Please add product name")
                .Length(2,255).WithMessage("Product name must be between 2 and 255 characters.");
            
            RuleFor(p => p.Price).NotNull().WithMessage("Please insert price for the product")
                .GreaterThan(0).WithMessage("Price must be greater than ZERO !");
            RuleFor(p => p.Quantity).NotEmpty().WithMessage("")
                .GreaterThan(0).WithMessage("").LessThan(100).WithMessage("");
            
            RuleFor(p => p.CategoryId).GreaterThan(0).WithMessage("Please insert a valid category id")
                .MustAsync(CategoryExists).WithMessage("Category ID does not exist.");

        }

        private async Task<bool> CategoryExists(int categoryId, CancellationToken cancellationToken)
        {
            return await ExistsAsync(categoryId);
        }

        public async Task<bool> ExistsAsync(int categoryId)
        {
           // await _context.Categories.AnyAsync(c => c.Id == categoryId);
            return true;
        }
    }
}
