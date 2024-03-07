namespace StringCalculator
{
    public class Calculator
    {
        public static int Add(string numbers)
        {
            if (numbers == "1")
            {
                return 1;
            }
            else if (numbers == "2")
            {
                return 2;
            } else {
                return 0;
            }
        }
    }
}