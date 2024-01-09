using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Common.ClassImplementation;
using Common;

namespace MyApp.Namespace
{
    [Route("[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {

        [HttpGet("Calculator")]
        public ActionResult<string> Result(){
            Calculator calculator = new Calculator("Operation name", 1);
            return calculator.Operation;
        }

        [HttpGet("Base")]
        public ActionResult<string> BaseResult()
        {
            Basic basic = new Basic();
            return $"{basic.RelativeError(4,2)}";
        }
    }

}
