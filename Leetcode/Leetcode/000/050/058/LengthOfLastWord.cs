namespace Leetcode
{
    using System;
    using System.Linq;

    public class LengthOfLastWord
    {
        private const string Space = " ";

        public static int Solution(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return 0;
            }

            var splited = s.Split(char.Parse(Space));
            var lastNonEmpty = splited.Last(x => !string.IsNullOrEmpty(x.Trim()));

            return lastNonEmpty.Length;
        }
    }
}
