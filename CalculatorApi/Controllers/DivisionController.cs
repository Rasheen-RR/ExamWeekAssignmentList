using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DivisionController : ControllerBase
    {

        [HttpGet]
        public dynamic Get([FromQuery(Name = "leftNumber")] double leftNumber, [FromQuery(Name = "rightNumber")] double rightNumber)
        {
            SimpleCalc simpleCalc = new SimpleCalc();

            if (rightNumber == 0)
            {
                return new { message = "Invalid Calculation" };
            }

            return new { leftNumber = leftNumber, rightNumber = rightNumber, result = simpleCalc.divideNumbers(leftNumber, rightNumber) };
        }


        [HttpPost]
        public dynamic Post([FromForm(Name = "leftNumber")] double leftNumber, [FromForm(Name = "rightNumber")] double rightNumber)
        {
            SimpleCalc simpleCalc = new SimpleCalc();

            if(rightNumber == 0)
            {
                return new { message = "Invalid Calculation" };
            }

            return new { leftNumber = leftNumber, rightNumber = rightNumber, result = simpleCalc.divideNumbers(leftNumber, rightNumber) };
        }


        [HttpOptions]
        public dynamic Options()
        {
            return new
            {
                info = "Get Request, Post Request to Divide two Numbers",
                get = "Gets two variables from queryString and divide the numbers",
                getRequestParameters = "leftNumber : Int/Double |||| rightNumber : Int/Double",
                post = "Gets two variables from form data and divide the numbers",
                postRequestParameters = "leftNumber : Int/Double |||| rightNumber : Int/Double"
            };
        }
    }
}
