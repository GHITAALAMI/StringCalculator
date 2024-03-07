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
            var negativenumbrs = numberlist.Where(X => X < 0).ToList();
            if (negativenumbrs.Any())
            {
                throw new NegativesNotAllowedException();
            }
        }
    }

    [Serializable]
    internal class NegativesNotAllowedException : Exception
    {
        public NegativesNotAllowedException()
        {
        }

        public NegativesNotAllowedException(string? message) : base(message)
        {
        }

        public NegativesNotAllowedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NegativesNotAllowedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}