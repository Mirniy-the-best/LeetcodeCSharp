using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _2215
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            return new List<IList<int>>() {
                nums1.Except(nums2).Distinct().ToList(),
                nums2.Except(nums1).Distinct().ToList()
            };
        }

    }
}