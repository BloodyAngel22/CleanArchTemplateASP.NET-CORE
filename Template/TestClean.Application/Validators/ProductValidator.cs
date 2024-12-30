using FluentValidation;
using TestClean.Core.Models;

namespace TestClean.Application.Validators
{
    public class ProductValidator: AbstractValidator<ProductDTO>
    {
		public ProductValidator()
		{
			RuleFor(x => x.Name)
				.NotEmpty()
				.WithMessage("Name is required");

			RuleFor(x => x.Price)
				.NotEmpty()
				.WithMessage("Price is required")
				.GreaterThan(0)
				.WithMessage("Price must be greater than 0");
		}
    }
}