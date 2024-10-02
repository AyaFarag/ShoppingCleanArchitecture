using FluentValidation;
using Shopping.Domain.Entities;


namespace Shopping.Application.Behaviors.Validation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(user => user.UserName).NotNull();
            RuleFor(user => user.Email).NotEmpty().MaximumLength(50);

        }
    }
}
