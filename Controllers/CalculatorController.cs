
using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {

        [HttpPost]
        public CalculatorResult Calculate([FromForm] double first, [FromForm] double second, [FromForm] string opt)
        {
            switch (opt)
            {
                case "+":
                    return Add(first, second);
                case "-":
                    return Sub(first, second);
                case "*":
                    return Multiple(first, second);
                case "/":
                    return Division(first, second);
            }
            return null;
        }

        [HttpGet("{first}/{second}")]
        public CalculatorResult[] Info(double first, double second)
        {
            CalculatorResult[] result = { Add(first, second), Sub(first, second), Multiple(first, second), Division(first, second) };
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

        [HttpGet("{first}/{second}/Multiple")]
        public CalculatorResult Multiple(double first, double second)
        {
            CalculatorResult result = new CalculatorResult { type = "Multiple", result = first * second };
            return result;
        }

        [HttpGet("{first}/{second}/Division")]
        public CalculatorResult Division(double first, double second)
        {
            if (second == 0)
                return new CalculatorResult { type = "divisor cannot be zero"};

            CalculatorResult result = new CalculatorResult { type = "Division", result = first / second };
            return result;
        }
    }
}
