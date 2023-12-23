using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Common;

namespace MyApp.Namespace
{
    [Route("[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet(Name = "Calculator")]
        public ActionResult<string> Result(){
            Calculator calculator = new Calculator("Operation name", 1);
            return calculator.Operation;
        }
    }
}
