namespace Leetcode
{
    using System;

    public class AddBinary
    {
        public static string Solution(string a, string b)
        {
            if (a.Length < b.Length)
            {
                string c = a;
                a = b;
                b = c;
            }

            var sum = new char[a.Length + 1];
            var carry = 0;

            for (int i = a.Length - 1, j = b.Length - 1, k = sum.Length - 1; i >= 0; i--, j--, k--)
            {
                int sumBits = (a[i] - '0') +
                              (j >= 0 ? b[j] - '0' : 0) +
                              carry;
                sum[k] = (char)((sumBits % 2) + '0');
                carry = sumBits > 1 ? 1 : 0;
            }

            if (carry > 0)
            {
                sum[0] = '1';
                return new string(sum);
            }

            return new string(sum, 1, sum.Length - 1);
        }
    }
}