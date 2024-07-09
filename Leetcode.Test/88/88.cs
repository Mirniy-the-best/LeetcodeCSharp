using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _88
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            m--;
            n--;
            for (int i = nums1.Length-1; i >=0 ; i--)
            {
                if (n < 0)
                    return;

                if (m < 0)
                {
                    nums1[i] = nums2[n];
                    n--;
                    continue;
                }

                if (nums2[n] >= nums1[m])
                {
                    nums1[i] = nums2[n];
                    n--;
                }
                else
                {
                    nums1[i] = nums1[m];
                    m--;
                }
            }
        }
    }
}