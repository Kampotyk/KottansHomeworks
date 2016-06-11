using System;
using System.Collections.Generic;

namespace StringCalculator
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            int result = 0;

            if (String.IsNullOrEmpty(numbers))
            {
                return result;
            }

            string delims = ",\n";

            if (numbers.Substring(0, 2).Equals("//") && numbers.Length > 2)
            {
                delims = numbers.Substring(2, 1);
            }

            var numberList = numbers.Trim().Split(delims.ToCharArray());

            foreach(var number in numberList)
            {
                result += Int32.Parse(number);
            }

            return result;
        }
    }
}
