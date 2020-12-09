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
    public class MultiplyController : ControllerBase
    {

        [HttpGet]
        public dynamic Get([FromQuery(Name = "leftNumber")] double leftNumber, [FromQuery(Name = "rightNumber")] double rightNumber)
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            return new { leftNumber = leftNumber, rightNumber = rightNumber, result = simpleCalc.mulitplyNumbers(leftNumber, rightNumber) };
        }


        [HttpPost]
        public dynamic Post([FromForm(Name = "leftNumber")] double leftNumber, [FromForm(Name = "rightNumber")] double rightNumber)
        {
            SimpleCalc simpleCalc = new SimpleCalc();
            return new { leftNumber = leftNumber, rightNumber = rightNumber, result = simpleCalc.mulitplyNumbers(leftNumber, rightNumber) };
        }

        [HttpOptions]
        public dynamic Options()
        {
            return new
            {
                info = "Get Request, Post Request to Multiply two Numbers",
                get = "Gets two variables from queryString and multiply the numbers",
                getRequestParameters = "leftNumber : Int/Double |||| rightNumber : Int/Double",
                post = "Gets two variables from form data and multiply the numbers",
                postRequestParameters = "leftNumber : Int/Double |||| rightNumber : Int/Double"
            };
        }

    }
}
