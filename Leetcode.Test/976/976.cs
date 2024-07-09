using System.Runtime.InteropServices;

namespace Leetcode.Test
{
    public class _976
    {
        public int LargestPerimeter(int[] nums)
        {
            Array.Sort(nums);
            for (int i = nums.Length-1; i>=2; i--)
                if (nums[i] < nums[i-1] + nums[i-2])
                    return nums[i] + nums[i-1] + nums[i-2];

            return 0;
        }

    }
}