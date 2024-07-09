using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _496
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            var stack = new Stack<int>();
            var maxes = new Dictionary<int, int>(nums2.Length);
            maxes.Add(nums2.Last(), -1);
            stack.Push(nums2.Last());

            for (int i = nums2.Length-2; i >= 0; i--)
            {
                maxes.Add(nums2[i], -1);

                while (stack.Count > 0)
                {
                    var item = stack.Peek();
                    if (item > nums2[i])
                    {
                        maxes[nums2[i]] = item;
                        break;
                    }
                    stack.Pop();
                }
                stack.Push(nums2[i]);
            }
            int[] result = new int[nums1.Length];
            for (int i = 0; i < result.Length; i++)
                result[i] = maxes[nums1[i]];
            return result;
        }
    }
}