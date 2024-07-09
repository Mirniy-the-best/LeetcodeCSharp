using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _169
    {
        public int MajorityElement(int[] nums)
        {
            var index = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (index.ContainsKey(nums[i]))
                    index[nums[i]]++;
                else
                    index.Add(nums[i], 1);
            }
            return index.MaxBy(x=>x.Value).Key;
        }

    }
}