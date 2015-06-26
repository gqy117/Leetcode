namespace Leetcode
{
    using System.Linq;

    public class SortColors
    {
        public static void Solution(int[] nums)
        {
            var listNums = nums.OrderBy(x => x).ToList();

            for (int i = 0; i < listNums.Count; i++)
            {
                nums[i] = listNums[i];
            }
        }
    }
}