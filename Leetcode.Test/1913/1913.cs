using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _1913
    {
        public int MaxProductDifference(int[] nums)
        {
            var ordered = nums.OrderBy(x => x).ToArray();
            return ordered[ordered.Length - 1] * ordered[ordered.Length - 2] - ordered[0] * ordered[1];
        }
    }
}