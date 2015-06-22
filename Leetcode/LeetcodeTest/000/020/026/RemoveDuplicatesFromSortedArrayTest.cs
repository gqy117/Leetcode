namespace LeetcodeTest
{
    using Leetcode;
    using NUnit.Framework;

    [TestFixture]
    public class RemoveDuplicatesFromSortedArrayTest
    {
        [TestCase(new int[] { 1, 1, 2 }, 2)]
        public void RemoveDuplicatesFromSortedArray_Default(int[] nums, int expected)
        {
            this.ExecuteSolution(nums, expected);
        }

        private void ExecuteSolution(int[] nums, int expected)
        {
            // Act
            var actual = RemoveDuplicatesFromSortedArray.Solution(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
