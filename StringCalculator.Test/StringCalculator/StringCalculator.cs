using System.Collections.Generic;
using System.Runtime.Serialization;

namespace StringCalculator
{
    public class Calculator
    {
        public static int Add(string numbers)
        {
            string[] strings = numbers.Split(',','\n');

            int sum = 0;
            List<int> numberlist = new List<int>();

            foreach (var s in strings)
            {
                if (int.TryParse(s, out int number))
                {
                    numberlist.Add(number); 
                }
            }

            CheckForNegativeNumbers(numberlist);
            return numberlist.Sum();
    }
        private static void CheckForNegativeNumbers(List<int> numberlist)
        {
            var negativenumbers = numberlist.Where(X => X < 0).ToList();
            if (negativenumbers.Any())
            {
                throw new NegativesNotAllowedException(negativenumbers);
            }
        }
    }

    public class NegativesNotAllowedException : Exception
    {
        public NegativesNotAllowedException(IEnumerable<int> negativenumbers)
            : base($"negatives not allowed : {string.Join(',', negativenumbers)}")
        {
            
        }

    }
}