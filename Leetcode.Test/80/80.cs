using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _80
    {
        public int RemoveDuplicates(int[] nums)
        {
            int l = 0;
            bool cnt = true;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[l] && cnt)
                {
                    cnt = false;
                    l++;
                    nums[l] = nums[i];
                    continue;
                }
                if (nums[i] > nums[l])
                {
                    cnt = true;
                    l++;
                    nums[l] = nums[i];
                }
            }
            return l+1;
        }

    }
}