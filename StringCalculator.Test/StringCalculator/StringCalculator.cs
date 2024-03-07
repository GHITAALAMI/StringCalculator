namespace StringCalculator
{
    public class Calculator
    {
        public static int Add(string numbers)
        {
            if (int.TryParse(numbers, out int number))
            {
                return number;
            }
            return 0;
        }
    }
}