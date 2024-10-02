using FluentValidation;
using Shopping.Application.DTOs;


namespace Shopping.Application.Behaviors.Validation
{
    public class CategoryValidator : AbstractValidator<CategoryDTO>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name)
             .NotEmpty().WithMessage("Please add Category name as it is required.")
             .Length(2, 50).WithMessage("Category name must be between 2 and 50 characters.");
        }
    }
}
