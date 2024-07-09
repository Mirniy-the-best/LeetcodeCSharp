using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _55
    {
        public bool CanJump(int[] nums)
        {
            int n = nums.Length;
            var res = new bool[n];
            res[0] = true;
            for (int i = 0; i < n; i++)
                if (res[i])
                    for (int j = 1; j <= nums[i] && i + j < n; j++)
                        res[i + j] = true;
            return res[n - 1];
        }
    }
}