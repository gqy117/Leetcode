namespace Leetcode
{
    using System;
    using System.Collections.Generic;

    public class LongestSubstringWithoutRepeatingCharacters
    {
        public static int Solution(string s)
        {
            int n = s.Length;
            var arrayS = s.ToCharArray();
            Dictionary<char, bool> distinctChar = new Dictionary<char, bool>();
            int result = 0;
            int currentCount = 0;

            for (int i = 0; i < n; i++)
            {
                int k = i;

                while (k < n)
                {
                    char currentChar = arrayS[k];

                    if (distinctChar.ContainsKey(currentChar))
                    {
                        distinctChar = new Dictionary<char, bool>();
                        currentCount = 0;
                        break;
                    }

                    k++;
                    currentCount++;
                    distinctChar.Add(currentChar, true);
                    result = Math.Max(result, currentCount);
                }
            }

            return result;
        }
    }
}