using Microsoft.AspNetCore.Mvc;

namespace RestWithAspnetUdemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Get(string firstNumber, string secondNumber)
        {
            if (IsNumerc(firstNumber) && IsNumerc(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Input!");
        }

        [HttpGet("substract/{firstNumber}/{secondNumber}")]
        public IActionResult GetSubstract(string firstNumber, string secondNumber)
        {
            if (IsNumerc(firstNumber) && IsNumerc(secondNumber))
            {
                var sub = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                return Ok(sub.ToString());
            }

            return BadRequest("Invalid Input!");
        }

        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult GetMultiplication(string firstNumber, string secondNumber)
        {
            if (IsNumerc(firstNumber) && IsNumerc(secondNumber))
            {
                var sub = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                return Ok(sub.ToString());
            }

            return BadRequest("Invalid Input!");
        }

        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult GetDivision(string firstNumber, string secondNumber)
        {
            if (IsNumerc(firstNumber) && IsNumerc(secondNumber))
            {
                var sub = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
                return Ok(sub.ToString());
            }

            return BadRequest("Invalid Input!");
        }


        [HttpGet("square-root/{firstNumber}")]
        public IActionResult GetSquareRoot(string firstNumber)
        {
            if (IsNumerc(firstNumber))
            {
                var squareRoot = Math.Sqrt((double)ConvertToDecimal(firstNumber));
                return Ok(squareRoot.ToString());
            }

            return BadRequest("Invalid Input!");
        }


        [HttpGet("mean/{firstNumber}/{secondNumber}")]
        public IActionResult GetMean(string firstNumber, string secondNumber)
        {
            if (IsNumerc(firstNumber) && IsNumerc(secondNumber))
            {
                var sum = (ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber))/2;
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Input!");
        }



        private bool IsNumerc(string strnumber)
        {
            double number;
            bool isNumber = double.TryParse(
                                            strnumber,
                                            System.Globalization.NumberStyles.Any,
                                            System.Globalization.NumberFormatInfo.InvariantInfo,
                                            out number);

            return isNumber;
        }

        private decimal ConvertToDecimal(string strnumber)
        {
            decimal decimalValue;
            if (decimal.TryParse(strnumber, out decimalValue))
            {
                return decimalValue;
            }

            return 0;
        }


    }
}