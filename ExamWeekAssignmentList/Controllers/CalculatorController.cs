using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorLibrary;
using ExamWeekAssignmentList.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExamWeekAssignmentList.Controllers
{
    public class CalculatorController : Controller
    {

        SimpleCalc simpleCalc = new SimpleCalc();


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
            cm.result = simpleCalc.OperatorSwitch(calculator.leftNumber, calculator.rightNumber, calculator.operat);

            return View("Index", cm);
        }

    }
}
