using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWeekAssignmentList.Models
{
    public class CalculatorModel
    {
        public double leftNumber { get; set; }

        [ZeroDivisionValidator]
        public double rightNumber { get; set; }

        [RegularExpression("([+*/-])", ErrorMessage = "Enter a valid operator (+,-,*,/)")]
        public string operat { get; set; }

        public double result { get; set; }

    }
}
