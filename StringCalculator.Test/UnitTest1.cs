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


        [Fact]
        public void ReturnTwoGivenTwo()
        {
            int result = Calculator.Add("2");

            int expected = 2;

            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "3")]
        [InlineData(4, "4")]

        public void ReturnNumberGivenNumberString(int expected, string input)
        {
            int result = Calculator.Add(input);

            Assert.Equal(expected, result);
        }




        [Theory]
        [InlineData(2, "1,1")]
        [InlineData(3, "1,2")]

        public void ReturnSumGivenTwoNumbers(int expected, string input)
        {
            int result = Calculator.Add(input);

            Assert.Equal(expected, result);
        }


    }
}