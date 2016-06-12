using System;
using System.Collections.Generic;

namespace Calculator
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            const string DelimPrefix = "//";
            const string DefaultDelims = ",\n";
            const int MaxNumber = 1000;

            int result = 0;
            int intNumber = 0;
            string delims = DefaultDelims;
            string negNumbers = String.Empty;
            string[] numberArray;
            string[] delimsArray;

            if (numbers.Length >= DelimPrefix.Length
                && numbers.Substring(0, DelimPrefix.Length).Equals(DelimPrefix))
            {
                var delimLine = numbers.Substring(DelimPrefix.Length).Split('\n')[0];
                if (delimLine.Length == 1)
                {
                    delimsArray = new string[] { delimLine };
                }
                else
                {
                    delimsArray = delimLine.Split(new char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                }
                numbers = numbers.Split('\n')[1];

                numberArray = numbers.Split(delimsArray, StringSplitOptions.None);
            }
            else
            {
                numberArray = numbers.Trim().Split(delims.ToCharArray());
            }

            if (numbers.Length == 0)
            {
                return result;
            }

            foreach (var strNumber in numberArray)
            {
                intNumber = Int32.Parse(strNumber);

                if (intNumber < 0)
                {
                    negNumbers = String.Join(", ", Array.FindAll(new[] { negNumbers, strNumber },
                                                                 number => !String.IsNullOrEmpty(number)));
                }
                else
                {
                    result += intNumber < MaxNumber ? intNumber : 0;
                }
            }

            if (negNumbers.Length > 0)
            {
                throw new InvalidOperationException(String.Format("Negatives not allowed: {0}", negNumbers));
            }

            return result;
        }
    }
}
