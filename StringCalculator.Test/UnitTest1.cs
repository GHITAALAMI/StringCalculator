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

        [Fact]
        public void ReturnOneGivenOne()
        {
            int result = Calculator.Add("1");

            int expected = 1;

            Assert.Equal(expected, result);
        }
    }
}