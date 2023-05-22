using System.ComponentModel.DataAnnotations;

namespace P01WebApplicationMVC.Models.Validators
{
    internal class AgeOverAttribute : ValidationAttribute // prowadzacy dal nazwe klasy AgeOver
    {
        public int Age { get; }
        public AgeOverAttribute(int age) 
        {
            Age = age;
        }

        public string GetErrorMessage() => $"Wiek musi byc powyzej {Age}";
        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            var member = (Member)validationContext.ObjectInstance;
            if(member.Age < Age )
            {
                return new ValidationResult(GetErrorMessage());
            }
            return ValidationResult.Success;
        }
    }
}