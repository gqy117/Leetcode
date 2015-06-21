namespace LeetcodeTest
{
    using Leetcode;
    using NUnit.Framework;

    [TestFixture]
    public class PalindromeNumberTest
    {
        [TestCase(121, true)]
        public void PalindromeNumber_Default(int x, bool expected)
        {
            this.ExecuteSolution(x, expected);
        }

        [TestCase(-121, false)]
        public void PalindromeNumber_Negative(int x, bool expected)
        {
            this.ExecuteSolution(x, expected);
        }

        [TestCase(0, true)]
        [TestCase(1, true)]
        public void PalindromeNumber_0(int x, bool expected)
        {
            this.ExecuteSolution(x, expected);
        }

        private void ExecuteSolution(int x, bool expected)
        {
            // Act
            var actual = PalindromeNumber.Solution(x);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
