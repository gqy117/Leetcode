namespace LeetcodeTest
{
    using Leetcode;
    using NUnit.Framework;

    public class SortColorsTest
    {
        [TestCase(new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 })]
        public void Pow_Default(int[] nums, int[] expected)
        {
            this.ExecuteSolution(nums, expected);
        }

        private void ExecuteSolution(int[] nums, int[] expected)
        {
            // Act
            SortColors.Solution(nums);

            // Assert
            Assert.AreEqual(expected, nums);
        }
    }
}