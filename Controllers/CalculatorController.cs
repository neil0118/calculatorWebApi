
using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("{first}/{second}")]
        public CalculatorResult[] Info(double first, double second)
        {
            CalculatorResult[] result = { Add(first, second), Sub(first, second), Mutiple(first, second), Division(first, second) };
            return result;
        }

        [HttpGet("{first}/{second}/Add")]
        public CalculatorResult Add(double first, double second)
        {
            CalculatorResult result = new CalculatorResult { type = "Add", result = first + second };
            return result;
        }

        [HttpGet("{first}/{second}/Sub")]
        public CalculatorResult Sub(double first, double second)
        {
            CalculatorResult result = new CalculatorResult { type = "Sub", result = first - second };
            return result;
        }

        [HttpGet("{first}/{second}/Mutiple")]
        public CalculatorResult Mutiple(double first, double second)
        {
            CalculatorResult result = new CalculatorResult { type = "Mutiple", result = first * second };
            return result;
        }

        [HttpGet("{first}/{second}/Division")]
        public CalculatorResult Division(double first, double second)
        {
            CalculatorResult result = new CalculatorResult { type = "Division", result = first / second };
            return result;
        }
    }
}