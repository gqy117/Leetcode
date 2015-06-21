namespace LeetcodeTest
{
    using Leetcode;
    using NUnit.Framework;

    [TestFixture]
    public class PalindromeNumberTest
    {
        [TestCase(121, true)]
        public void PalindromeNumber_Default(int x, int expected)
        {
            this.ExecuteSolution(x, expected);
        }

        private void ExecuteSolution(int x, int expected)
        {
            // Act
            var actual = PalindromeNumber.Solution(x);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
