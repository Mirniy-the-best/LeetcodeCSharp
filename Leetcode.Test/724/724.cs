using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _724
    {
        public int PivotIndex(int[] nums)
        {
            int ls = 0;
            var rs = nums.Sum();
            for (int m = 0; m < nums.Length; m++)
            {
                rs -= nums[m];
                if (ls == rs) return m;
                ls += nums[m];
            }
            return -1;
        }

    }
}