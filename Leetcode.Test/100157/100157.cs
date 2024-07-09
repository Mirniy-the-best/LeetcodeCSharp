using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _100157
    {
        public int MissingInteger(int[] nums)
        {
            if(nums.Length == 1) return nums[0]+1;
            int l = 0, r = 0;
            int lmax = l, rmax = r;
            int maxlen = 1;

            int len = 1;
            bool isChain = true;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1]+1)
                {
                    if (isChain)
                    {
                        len++;
                        r = i;
                        if (len > maxlen)
                        {
                            maxlen = len;
                            rmax = i;
                            lmax = l;
                        }
                    }
                    else
                    {
                        l = i;
                        len = 1;
                        r = i;
                    }
                }
                else
                {
                    isChain = false;
                }
            }

            var sum = 0;
            for (int i = lmax; i <= rmax; i++)
            {
                sum += nums[i];
            }
            do
            {
                var p = -1;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == sum)
                    {
                        p = i;
                        break;
                    }
                }
                if (p >= 0)
                    sum++;
                else
                    return sum;
            } while (true);

        }
    }
}