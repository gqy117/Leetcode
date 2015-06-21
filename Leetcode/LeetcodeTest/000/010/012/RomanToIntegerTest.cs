namespace LeetcodeTest
{
    using Leetcode;
    using NUnit.Framework;

    [TestFixture]
    public class RomanToIntegerTest
    {
        [TestCase("V", 5)]
        public void RomanToInteger_Default(string s, int expected)
        {
            this.ExecuteSolution(s, expected);
        }

        private void ExecuteSolution(string s, int expected)
        {
            // Act
            var actual = RomanToInteger.Solution(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
