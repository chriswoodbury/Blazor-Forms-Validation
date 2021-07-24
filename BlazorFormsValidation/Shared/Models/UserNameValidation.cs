using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorFormsValidation.Shared.Models
{
    class UserNameValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (!value.ToString().ToLower().Contains("admin"))
            {
                return null;
            }

            return new ValidationResult("The User Name cannot contain the word admin",
                new[] { validationContext.MemberName });
        }
    }
}
