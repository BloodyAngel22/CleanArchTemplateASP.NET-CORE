using FluentValidation;
using Template.Application.DTOs.Request;

namespace Template.Application.Validators;

public class ProductDTORequestValidator : AbstractValidator<ProductDTORequest>
{
    public ProductDTORequestValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");

        RuleFor(x => x.Price)
            .NotEmpty()
            .WithMessage("Price is required")
            .GreaterThan(0)
            .WithMessage("Price must be greater than 0");
    }
}
