namespace Leetcode
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class TwoSum
    {
        public static int[] Solution(int[] nums, int target)
        {
            int n = nums.Length;
            IList<SortedNum> sortedNums = new List<SortedNum>();

            for (int i = 0; i < n; i++)
            {
                sortedNums.Add(new SortedNum { Index = i, Value = nums[i] });
            }

            sortedNums = sortedNums.OrderBy(x => x.Value).ToList();

            for (int i = 0;
                i < sortedNums.Count - 1
                && sortedNums[i].Value + sortedNums[i + 1].Value <= target;
                i++)
            {
                for (int j = i + 1; j < sortedNums.Count
                && sortedNums[i].Value + sortedNums[j].Value <= target; j++)
                {
                    if (sortedNums[i].Value + sortedNums[j].Value == target)
                    {
                        return new int[] { sortedNums[i].Index + 1, sortedNums[j].Index + 1 }.OrderBy(x => x).ToArray();
                    }
                }
            }

            throw new IndexOutOfRangeException();
        }

        private class SortedNum
        {
            public int Index { get; set; }

            public int Value { get; set; }
        }
    }
}
