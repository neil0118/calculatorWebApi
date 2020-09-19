
using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("{first}/{second}")]
        public double[] Info(double first, double second)
        {
            double[] result = {Add(first,second),Sub(first,second),Mutiple(first,second),Division(first,second)};
            return result;
        }

        [HttpGet("{first}/{second}/Add")]
        public double Add(double first, double second)
        {
            return first + second;
        }

        [HttpGet("{first}/{second}/Sub")]
        public double Sub(double first, double second)
        {
            return first - second;
        }

        [HttpGet("{first}/{second}/Mutiple")]
        public double Mutiple(double first, double second)
        {
            return first * second;
        }

        [HttpGet("{first}/{second}/Division")]
        public double Division(double first, double second)
        {
            return first / second;
        }
    }
}