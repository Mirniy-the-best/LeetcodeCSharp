using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _219
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var index = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
                if (index.ContainsKey(nums[i]))
                    if (i-index[nums[i]] <= k) return true;
                    else index[nums[i]] = i;
                else
                    index.Add(nums[i], i);
            return false;
        }
    }
}