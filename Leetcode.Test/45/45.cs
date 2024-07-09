using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _45
    {
        public int Jump(int[] nums)
        {
            int n = nums.Length;
            var res = new int[n];

            for (int i = 0; i < n; i++)
            {
                var num = nums[i];
                for (int j = 1; j <= num && i + j < n; j++)
                {
                    if (i + j < n)
                        if(res[i + j] == 0)
                            res[i + j] = res[i] + 1;
                        else
                            res[i + j] = Math.Min(res[i + j], res[i] + 1);
                }
            }

            return res[n - 1];
        }
    }
}