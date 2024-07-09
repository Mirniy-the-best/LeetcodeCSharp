using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var cache = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var delta = target - nums[i];
                if (cache.ContainsKey(delta))
                { return new[] { cache[delta], i }; }

                cache.TryAdd(nums[i], i);
            }
            return new[] { 0 };
        }
    }
}