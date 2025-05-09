using FluentValidation.Results;

namespace Template.Core.Entities;

public class ValidatorError
{
    public required string ErrorMessage { get; set; }

    public static List<ValidatorError> GetErrors(ValidationResult validationResult)
    {
        return validationResult
            .Errors.Select(x => new ValidatorError { ErrorMessage = x.ErrorMessage })
            .ToList();
    }

    public static string GetErrorMessages(List<ValidatorError> errors) =>
        string.Join(", ", errors.Select(x => x.ErrorMessage));
}
