using FluentValidation;
using Template.Application.DTOs.Request;

namespace Template.Application.Validators;

public class PaginationDTORequestValidator : AbstractValidator<PaginationDTORequest>
{
    public PaginationDTORequestValidator()
    {
        RuleFor(x => x.Page).GreaterThan(0).WithMessage("Page must be greater than 0");

        RuleFor(x => x.PageSize)
            .GreaterThan(0)
            .WithMessage("PageSize must be greater than 0")
            .LessThan(50)
            .WithMessage("PageSize must be less than 50");
    }
}
