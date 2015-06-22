namespace Leetcode
{
    using System;
    using System.Linq;

    public class RemoveDuplicatesFromSortedArray
    {
        public static int Solution(int[] nums)
        {
            int duplicated = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    duplicated++;
                }
            }

            return nums.Length - duplicated;
        }
    }
}