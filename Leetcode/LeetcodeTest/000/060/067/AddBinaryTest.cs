namespace LeetcodeTest
{
    using Leetcode;
    using NUnit.Framework;

    [TestFixture]
    public class AddBinaryTest
    {
        [TestCase("11", "1", "100")]
        public void AddBinary_Default(string a, string b, string expected)
        {
            this.ExecuteSolution(a, b, expected);
        }

        private void ExecuteSolution(string a, string b, string expected)
        {
            // Act
            var actual = AddBinary.Solution(a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
