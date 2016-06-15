using System;

namespace Calculator
{
    public class StringCalculator
    {

        public int Add(string input)
        {          
            if (input.Length == 0)
            {
                return 0;
            }

            var numbersStr = StringCalculatorHelper.SplitStringToNumbersArray(input);
            var numbers = StringCalculatorHelper.ParseStringArrayToIntArray(numbersStr);
            var negNumbers = StringCalculatorHelper.GetNegativeNumbers(numbers);

            if (negNumbers.Length == 0)
            {
                return StringCalculatorHelper.GetNumbersSum(numbers);
            }
            else
            {
                throw new InvalidOperationException(String.Format("Negatives not allowed: {0}", negNumbers));
            }
        }
    }
}
