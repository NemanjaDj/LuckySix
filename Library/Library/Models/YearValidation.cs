using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class YearValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var book = (Book)validationContext.ObjectInstance;

            if(book.ReleaseYear > 1850 && book.ReleaseYear < 2020)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Release year is not valid!");
        }
    }
}
