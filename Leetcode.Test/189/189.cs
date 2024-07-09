using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _189
    {
        public void Rotate(int[] nums, int k)
        {
            k = k%nums.Length;
            reverse(nums, 0, nums.Length-1);
            reverse(nums, 0, k-1);
            reverse(nums, k, nums.Length-1);
        }

        private void reverse(int[] nums, int l, int r)
        {
            while (l < r)
            {
                var b = nums[l];
                nums[l] = nums[r];
                nums[r] = b;
                l++;
                r--;
            }
        }
    }
}