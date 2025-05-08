using Template.Core.Entities;

namespace Template.Core.Exceptions
{
	public class ValidateException(string message) : Exception(message)
	{
    }
}