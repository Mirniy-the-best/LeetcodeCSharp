using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _35
    {
        public int SearchInsert(int[] nums, int target)
        {
            int l=0; int r=nums.Length-1;
            while(l<=r)
            {
                int m = l + (r - l) / 2;
                if (nums[m] == target) { return m; }
                if (nums[m] > target) r = m - 1;
                else l = m + 1;
            }
            return l;
        }

    }
}