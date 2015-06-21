namespace Leetcode
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class PalindromeNumber
    {
        public static bool Solution(int x)
        {
            string stringX = x.ToString();

            IList<char> charArrayX = stringX.ToCharArray().ToList();

            bool result = true;

            while (charArrayX.Any())
            {
                char first = charArrayX[0];
                char last = charArrayX[charArrayX.Count - 1];

                if (first != last)
                {
                    result = false;
                    break;
                }

                RemoveFirst(charArrayX);
                RemoveLast(charArrayX);
            }

            return result;
        }

        private static void RemoveLast(IList<char> charArrayX)
        {
            if (charArrayX.Any())
            {
                charArrayX.RemoveAt(charArrayX.Count - 1);
            }
        }

        private static void RemoveFirst(IList<char> charArrayX)
        {
            charArrayX.RemoveAt(0);
        }
    }
}