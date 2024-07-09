using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _643
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            var s = nums.Take(k).Sum();
            double max = s;
            for (int i = k; i < nums.Length; i++)
            {
                s += nums[i];
                s -= nums[i - k];
                if (s > max) max = s;
            }
            return max / k;
        }

    }
}