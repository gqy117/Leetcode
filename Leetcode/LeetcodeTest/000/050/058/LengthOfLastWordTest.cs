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

        private void ExecuteSolution(string s, int expected)
        {
            // Act
            var actual = LengthOfLastWord.Solution(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
