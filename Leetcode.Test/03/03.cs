using System.Collections;
using System.Collections.Immutable;

namespace Leetcode.Test
{
    public class _03
    {
        public bool CanSortArray(int[] nums)
        {
            for (int j = 0; j < nums.Length; j++)
                for (int i = 0;i< nums.Length -1; i++)
                {
                    if (nums[i] > nums[i+1] && int.PopCount(nums[i]) == int.PopCount(nums[i+1]))
                    {
                        (nums[i], nums[i + 1]) = (nums[i + 1], nums[i]);
                    }
                }
            return Enumerable.SequenceEqual(nums, nums.Order());
        }



    }
}