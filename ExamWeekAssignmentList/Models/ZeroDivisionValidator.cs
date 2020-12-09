using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWeekAssignmentList.Models
{
    public class ZeroDivisionValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var equaltion = (CalculatorModel)validationContext.ObjectInstance;

            if (equaltion.operat.Equals("/") && equaltion.rightNumber == 0)
            {
                return new ValidationResult("Divsion cannot be done by 0");
            }

            return ValidationResult.Success;
        }
    }
}
