namespace LeetcodeTest
{
    using Leetcode;
    using NUnit.Framework;

    public class PowTest
    {
        [TestCase((double)2.0, 2, 4)]
        public void Pow_Default(double x, int n, double expected)
        {
            this.ExecuteSolution(x, n, expected);
        }

        private void ExecuteSolution(double x, int n, double expected)
        {
            // Act
            var actual = Pow.Solution(x, n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
