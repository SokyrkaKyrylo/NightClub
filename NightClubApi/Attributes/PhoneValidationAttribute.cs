using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace NightClubApi.Attributes
{
    public class PhoneValidationAttribute : ValidationAttribute
    {
        public string PhoneRule { get; }

        private static string[] _existingPhones = new[]
        {
            "+(380)-00-000-0000",
            "+(380)-66-524-3927",
            "+(380)-66-525-3927"
        };

        public PhoneValidationAttribute(string phoneRule)
        {
            PhoneRule = phoneRule;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var phoneNumber = (string)(value ?? string.Empty);

            var regex = new Regex(PhoneRule);

            var validationResult = new ValidationResult("Phone format isn't valid, should be +(380)-XX-XXX-XXX");

            if (regex.IsMatch(phoneNumber))
            {
                if (_existingPhones.FirstOrDefault(phone => phone.Equals(phoneNumber)) is not null)
                {
                    validationResult.ErrorMessage = "The user with this phone is already exist";
                }
                else
                {
                    validationResult = ValidationResult.Success;
                }
            }

            return validationResult;
        }
    }
}
