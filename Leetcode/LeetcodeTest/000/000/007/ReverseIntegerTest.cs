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

        [TestCase(-123, -321)]
        public void ReverseInteger_Negative(int x, int expected)
        {
            this.ExecuteSolution(x, expected);
        }

        [TestCase(1534236469, 0)]
        public void ReverseInteger_BigNumber(int x, int expected)
        {
            this.ExecuteSolution(x, expected);
        }

        [TestCase(-2147483648, 0)]
        public void ReverseInteger_SmallNegative(int x, int expected)
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
