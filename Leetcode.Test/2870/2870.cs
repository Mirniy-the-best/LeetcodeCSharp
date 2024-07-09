using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _2870
    {
        public int MinOperations(int[] nums)
        {
            var counts = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!counts.ContainsKey(nums[i]))
                    counts[nums[i]] = 1;
                else
                    counts[nums[i]]++;
            }
            var result = 0;
            foreach (var pair in counts)
            {
                if (pair.Value == 1) return -1;
                result += pair.Value / 3;
                if (pair.Value % 3 > 0) result ++;
            }
            return result;
        }
    }
}