﻿namespace Leetcode.Test
{
    public class _136
    {
        public int SingleNumber(int[] nums)
        {
            var res = nums[0];
            for (int i = 1;i<nums.Length; i++)
                res ^= nums[i];
            return res;
        }

    }
}