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
        [InlineData(6, "1,2,3")]

        public void ReturnSumGivenTwoNumbers(int expected, string input)
        {
            int result = Calculator.Add(input);

            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData(7, "1,1,5")]
        [InlineData(9, "1,2,3,3")]
        [InlineData(22, "11,10,1")]

        public void ReturnSumGivenMultiplenumbers(int expected, string input)
        {
            int result = Calculator.Add(input);

            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(7, "1\n1,5")]
        [InlineData(9, "1,2\n3\n3")]

        public void ReturnSumGivenMultiplenumbersAndSpaces(int expected, string input)
        {
            int result = Calculator.Add(input);

            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData(0, "//;\n1;2")]
        [InlineData(9, "1,2\n3\n3")]

        public void ReturnSumGivenCustomDelimitedNumbers(int expected, string input)
        {
            int result = Calculator.Add(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ThrowExceptionGivenNegativeNumber()
        {
            void testcode() => Calculator.Add("-1,-4,7");
            var exception = Assert.Throws<NegativesNotAllowedException>((Action) (testcode));
            Assert.Contains("-1", exception.Message);
            Assert.Contains("-4", exception.Message);
            Assert.DoesNotContain("7", exception.Message);
        }
    }
}