using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _283
    {
        public void MoveZeroes(int[] nums)
        {
            int nullPointer = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    if (nums[nullPointer] == 0)
                        (nums[i], nums[nullPointer]) = (nums[nullPointer], nums[i]);
                    nullPointer++;
                }
            }
        }
    }
}