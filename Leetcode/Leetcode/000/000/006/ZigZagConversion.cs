namespace Leetcode
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ZigZagConversion
    {
        public static string Solution(string s, int numRows)
        {
            var stringBuilders = InitStringBuilders(numRows);

            int row = 0;
            int column = 0;
            var charS = s.ToCharArray();
            int lastZiprow = numRows - 1;

            for (int i = 0; i < charS.Length; i++)
            {
                char currentChar = charS[i];

                stringBuilders[row].Append(currentChar);

                if (IsNeedChangeColumn(numRows, row, column))
                {
                    if (NextColumnIsZipColumn(column, numRows))
                    {
                        row = GetZipRow(numRows, row, lastZiprow);
                        lastZiprow = row;
                    }
                    else
                    {
                        row = 0;
                    }

                    column++;
                }
                else
                {
                    row++;
                }
            }

            var result = AppendResult(numRows, stringBuilders);

            return result.ToString();
        }

        private static int GetZipRow(int numRows, int row, int lastZiprow)
        {
            row = lastZiprow == 0 ? numRows - 1 : lastZiprow - 1;

            return row;
        }

        private static StringBuilder AppendResult(int numRows, IList<StringBuilder> stringBuilders)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < numRows; i++)
            {
                result.Append(stringBuilders[i]);
            }

            return result;
        }

        private static IList<StringBuilder> InitStringBuilders(int numRows)
        {
            IList<StringBuilder> stringBuilders = new List<StringBuilder>();

            for (int i = 0; i < numRows; i++)
            {
                stringBuilders.Add(new StringBuilder());
            }

            return stringBuilders;
        }

        private static bool NextColumnIsZipColumn(int column, int numRows)
        {
            return !IsZipColumn(column, numRows);
        }

        private static bool IsNeedChangeColumn(int numRows, int row, int column)
        {
            return IsTheLastRow(numRows, row) || IsZipColumn(column, numRows);
        }

        private static bool IsZipColumn(int column, int numRows)
        {
            return 0 != column % (numRows - 1);
        }

        private static bool IsTheLastRow(int numRows, int row)
        {
            return numRows - 1 == row;
        }
    }
}
