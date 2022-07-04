using System.ComponentModel.DataAnnotations;

namespace NightClubApi.Attributes
{
    public class AgeValidationAttribute : ValidationAttribute
    {
        public int MinAge { get; }
        public int MaxAge { get; }

        public AgeValidationAttribute(int minAge, int maxAge)
        {
            MinAge = minAge;
            MaxAge = maxAge;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var age = (int)(value ?? 0);

            var result = new ValidationResult($"The user age must be more than {MinAge} and less than {MaxAge}");

            if (age > MinAge && age < MaxAge)
            {
                result = ValidationResult.Success;
            }

            return result;
        }
    }
}
