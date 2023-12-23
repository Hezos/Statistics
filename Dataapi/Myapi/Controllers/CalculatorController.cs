using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace MyApp.Namespace
{
    [Route("[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet(Name = "Calculator")]
        public ActionResult<string> Result(){
            
            
            return "Handling Request";
        }
    }
}
