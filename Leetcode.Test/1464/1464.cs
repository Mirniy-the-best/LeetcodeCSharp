using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _1464
    {
        public int MaxProduct(int[] nums)
        {
            int imax = 0;
            int jmax = 0;
            int maxi = -1;
            int maxj = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > maxi)
                {
                    maxi = nums[i];
                    imax = i;
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > maxj && imax != i)
                {
                    maxj = nums[i];
                    jmax = i;
                }
            }
            return (nums[imax] - 1) * (nums[jmax] - 1);
        }
    }

    [TestFixture]
    public class _1464_Tests
    {
        [Test]
        [TestCase(new[] { 3, 4, 5, 2 }, 12)]
        [TestCase(new[] { 1, 5, 4, 5}, 16)]
        [TestCase(new[] { 3, 7 }, 12)]
        [TestCase(new[] { 3, 1, 1 }, 0)]
        public void Test1(int[] nums, int expected)
        {
            var actual =  new _1464().MaxProduct(nums);
            Assert.AreEqual(expected, actual);

        }
    }
}