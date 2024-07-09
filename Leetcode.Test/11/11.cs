using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _11
    {
        public int MaxArea(int[] height)
        {
            int max = 0;
            int l = 0;
            var r = height.Length - 1;
            while (l < r)
            {
                var rc = (r - l) * Math.Min(height[r],height[l]);
                if(rc > max) max = rc;
                if (height[r] > height[l]) l++; else r--;
            }
            return max;
        }
    }
}