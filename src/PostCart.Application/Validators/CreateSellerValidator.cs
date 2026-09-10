using FluentValidation;
using PostCart.Application.DTOs.Requests;

namespace PostCart.Application.Validators
{

    public class CreateSellerValidator : AbstractValidator<CreateSellerRequest>
    {
        public CreateSellerValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required")
                .EmailAddress().WithMessage("Invalid email address");

            RuleFor(x => x.Username)
                .NotEmpty().WithMessage("Username is required")
                .MinimumLength(3).WithMessage("Username must be at least 3 characters long");
            
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required")
                .MinimumLength(8).WithMessage("Password must be at least 8 characters long");
        }
    }
}       