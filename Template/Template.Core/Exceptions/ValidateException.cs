using Template.Core.Entities;

namespace Template.Core.Exceptions
{
	public class ValidateException : Exception
	{
		public IEnumerable<ValidatorError> Errors { get; }

		public ValidateException(IEnumerable<ValidatorError> errors) : base("Validation Error")
		{
			Errors = errors;
		}
	}
}