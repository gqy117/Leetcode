namespace Leetcode
{
    using System;
    using System.Linq;

    public class ReverseInteger
    {
        public static int Solution(int x)
        {
            bool isNegative = x < 0;
            long longX = Math.Abs((long)x);

            var charX = longX.ToString().ToCharArray();
            string reverseString = new string(charX.Reverse().ToArray());

            int result = 0;
            bool success = int.TryParse(reverseString, out result);

            result = isNegative ? result * -1 : result;

            return result;
        }
    }
}