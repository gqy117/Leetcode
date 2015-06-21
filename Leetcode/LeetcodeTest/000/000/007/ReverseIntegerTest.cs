namespace LeetcodeTest
{
    using Leetcode;
    using NUnit.Framework;

    [TestFixture]
    public class ReverseIntegerTest
    {
        [TestCase(123, 321)]
        public void ReverseInteger_Default(int x, int expected)
        {
            this.ExecuteSolution(x, expected);
        }

        private void ExecuteSolution(int x, int expected)
        {
            // Act
            var actual = ReverseInteger.Solution(x);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
