using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _27
    {
        public int RemoveElement(int[] nums, int val)
        {
            var l = 0;
            var r = nums.Length - 1;
            while (l <= r) {
                while (nums[r] == val && r > l)
                    r--;

                if (nums[r] == val)
                    return l;

                if (nums[l] == val)
                {
                    nums[l] = nums[r];
                    r--;
                }
                l++;
            }
            return l;
        }
    }
}