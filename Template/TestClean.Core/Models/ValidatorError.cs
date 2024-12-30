using FluentValidation.Results;

namespace TestClean.Core.Models
{
    public class ValidatorError
    {
		public required string PropertyName { get; set; }
		public required string ErrorMessage { get; set; }

		public static List<ValidatorError> GetErrors(ValidationResult validationResult)
		{
			return validationResult.Errors.Select(x => new ValidatorError
			{
				PropertyName = x.PropertyName,
				ErrorMessage = x.ErrorMessage
			}).ToList();
		}
    }
}