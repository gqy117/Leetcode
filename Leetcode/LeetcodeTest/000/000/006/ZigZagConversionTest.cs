namespace LeetcodeTest
{
    using Leetcode;
    using NUnit.Framework;

    public class ZigZagConversionTest
    {
        [TestCase("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
        public void ZigZagConversion_Default(string text, int numRows, string expected)
        {
            this.ExecuteSolution(text, numRows, expected);
        }

        [TestCase("ABC", 2, "ACB")]
        [TestCase("ABCD", 2, "ACBD")]
        public void ZigZagConversion_NumRows2(string text, int numRows, string expected)
        {
            this.ExecuteSolution(text, numRows, expected);
        }

        [TestCase("ABCDEFGHIJKL", 5, "AGBHCFILDJEK")]
        public void ZigZagConversion_NumRows5(string text, int numRows, string expected)
        {
            this.ExecuteSolution(text, numRows, expected);
        }

        private void ExecuteSolution(string text, int numRows, string expected)
        {
            // Act
            var actual = ZigZagConversion.Solution(text, numRows);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
