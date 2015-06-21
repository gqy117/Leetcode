namespace LeetcodeTest
{
    using Leetcode;
    using NUnit.Framework;

    [TestFixture]
    public class RomanToIntegerTest
    {
        [TestCase("V", 10)]
        public void RomanToInteger_Default(string s, bool expected)
        {
            this.ExecuteSolution(s, expected);
        }

        private void ExecuteSolution(string s, bool expected)
        {
            // Act
            var actual = RomanToInteger.Solution(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
