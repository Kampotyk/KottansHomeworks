using System;

namespace Calculator
{
    public class StringCalculatorHelper
    {
        public const int MaxNumber = 1000;
        public const string DelimPrefix = "//";
        public const string DefaultDelims = ",\n";

        public static int GetNumbersSum(int[] numbers)
        {
            
            var result = 0;

            foreach (var number in numbers)
            {
                result += number < MaxNumber ? number : 0;
            }

            return result;
        }

        public static string[] SplitStringToNumbersArray(string input)
        {
            string[] numbers;
            string[] delims;

            if (input.Length >= DelimPrefix.Length
                && input.Substring(0, DelimPrefix.Length).Equals(DelimPrefix))
            {
                var delimStr = input.Substring(DelimPrefix.Length).Split('\n')[0];
                if (delimStr.Length == 1)
                {
                    delims = new string[] { delimStr };
                }
                else
                {
                    delims = delimStr.Split(new char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                }
                input = input.Split('\n')[1];

                numbers = input.Split(delims, StringSplitOptions.None);
            }
            else
            {
                numbers = input.Trim().Split(DefaultDelims.ToCharArray());
            }

            return numbers;
        }

        public static int[] ParseStringArrayToIntArray(string[] numbers)
        {
            var result = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = Int32.Parse(numbers[i]);
            }

            return result;
        }

        public static string GetNegativeNumbers(int[] numbers)
        {
            return String.Join(", ", Array.FindAll(numbers, number => number < 0));
        }
    }
}
