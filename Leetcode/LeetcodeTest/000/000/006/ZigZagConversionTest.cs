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

        private void ExecuteSolution(string text, int numRows, string expected)
        {
            // Act
            var actual = ZigZagConversion.Solution(text, numRows);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
