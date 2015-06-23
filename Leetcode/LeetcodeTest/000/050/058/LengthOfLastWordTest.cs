namespace LeetcodeTest
{
    using Leetcode;
    using NUnit.Framework;

    [TestFixture]
    public class LengthOfLastWordTest
    {
        [TestCase("Hello World", 5)]
        public void LengthOfLastWord_Default(string s, int expected)
        {
            this.ExecuteSolution(s, expected);
        }

        [TestCase("a", 1)]
        public void LengthOfLastWord_a1(string s, int expected)
        {
            this.ExecuteSolution(s, expected);
        }

        [TestCase("a ", 1)]
        public void LengthOfLastWord_a1WithSpaceInTheEnd(string s, int expected)
        {
            this.ExecuteSolution(s, expected);
        }

        [TestCase(" a ", 1)]
        public void LengthOfLastWord_a1WithSpaceInTheEndAndBeginning(string s, int expected)
        {
            this.ExecuteSolution(s, expected);
        }

        [TestCase(" ", 0)]
        public void LengthOfLastWord_Space(string s, int expected)
        {
            this.ExecuteSolution(s, expected);
        }

        private void ExecuteSolution(string s, int expected)
        {
            // Act
            var actual = LengthOfLastWord.Solution(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
