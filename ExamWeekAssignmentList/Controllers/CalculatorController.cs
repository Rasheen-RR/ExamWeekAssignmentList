using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamWeekAssignmentList.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExamWeekAssignmentList.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Index")]
        public IActionResult IndexPost([Bind("leftNumber,rightNumber,operat")] CalculatorModel calculator)
        {
            CalculatorModel cm = new CalculatorModel();
            cm.rightNumber = calculator.rightNumber;
            cm.leftNumber = calculator.leftNumber;
            cm.operat = calculator.operat;
            cm.result = calculationResult(calculator.leftNumber, calculator.rightNumber, calculator.operat);

            return View("Index", cm);
        }


        public double calculationResult(double leftNumber, double rightNumber, string op)
        {

            double result = double.NaN;

            switch (op)
            {
                case "+":
                    result = leftNumber + rightNumber;
                    break;
                case "-":
                    result = leftNumber - rightNumber;
                    break;
                case "*":
                    result = leftNumber * rightNumber;
                    break;
                case "/":
                    if (rightNumber != 0)
                    {
                        result = leftNumber / rightNumber;
                    }
                    break;
                default:
                    break;
            }
            return result;
        }

    }
}
