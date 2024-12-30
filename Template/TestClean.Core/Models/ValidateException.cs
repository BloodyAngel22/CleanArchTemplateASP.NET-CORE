namespace TestClean.Core.Models
{
    public class ValidateException: Exception
    {
		public IEnumerable<ValidatorError> Errors { get; }

		public ValidateException(IEnumerable<ValidatorError> errors): base("Validation Error")
		{
			Errors = errors;
		}


    }
}