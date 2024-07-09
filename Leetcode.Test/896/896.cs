using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _896
    {
        public bool IsMonotonic(int[] nums)
        {
            int asc = 0, desc = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] >= nums[i + 1]) desc++;
                if (nums[i] <= nums[i + 1]) asc++;
            }
            return asc == nums.Length - 1 || desc == nums.Length - 1;
        }

    }
}