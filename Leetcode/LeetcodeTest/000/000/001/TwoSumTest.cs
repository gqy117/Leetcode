﻿namespace LeetcodeTest
{
    using Leetcode;
    using NUnit.Framework;

    [TestFixture]
    public class TwoSumTest
    {
        [TestCase(new int[] { 2, 7, 11, 15 }, 9, new int[] { 1, 2 })]
        public void TwoSum_Default(int[] nums, int target, int[] expected)
        {
            this.ExecuteSolution(nums, target, expected);
        }

        [TestCase(new int[] { 3, 2, 4 }, 6, new int[] { 2, 3 })]
        public void TwoSum_NotSorted(int[] nums, int target, int[] expected)
        {
            this.ExecuteSolution(nums, target, expected);
        }

        [TestCase(new int[] { -1, -2, -3, -4, -5 }, -8, new int[] { 3, 5 })]
        public void TwoSum_NegativeNotSorted(int[] nums, int target, int[] expected)
        {
            this.ExecuteSolution(nums, target, expected);
        }

        private void ExecuteSolution(int[] nums, int target, int[] expected)
        {
            // Act
            var actual = TwoSum.Solution(nums, target);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
