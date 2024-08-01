using System.ComponentModel.DataAnnotations;

namespace MvcValidationsExample.CustomValidations
{
    public class ValidateNameAttribute : ValidationAttribute
    {
        public ValidateNameAttribute()
        {
            const string defaultErrorMessage = "Error with Name";
            ErrorMessage ??= defaultErrorMessage;
        }

        protected override ValidationResult? IsValid(object? value,
                                             ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
            {
                return new ValidationResult("Name is required.");
            }

            if (value.ToString()!.ToLower().Contains("@"))
            {

                return new ValidationResult(
                            FormatErrorMessage(validationContext.DisplayName));
            }

            return ValidationResult.Success;
        }
    }
}
