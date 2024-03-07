namespace StringCalculator
{
    public class Calculator
    {
        public static int Add(string numbers)
        {
            string[] strings = numbers.Split(',','\n');

            int sum = 0;
            foreach (var s in strings)
            {
                if (int.TryParse(s, out int number))
                {
                    sum += number;
                }
            }
            return sum;
    }
    }
}