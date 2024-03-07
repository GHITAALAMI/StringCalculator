using System.Security.Cryptography.X509Certificates;
using StringCalculator;
namespace StringCalculator.Test
{
    public class StringCalculatorShouldAdd
    {
        [Fact]
        public void ReturnZeroGivenEmptyString()
        {
            int result = Calculator.Add("0");

            int expected = 0;

            Assert.Equal(expected, result);
        }
    }
}