//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _1_Tests
	{

		[Test]
		[TestCase(new[] { 2, 7, 11, 15 }, 9, new[] {0,1})]
		[TestCase(new[] { 3, 2, 4 }, 6, new[] {1,2})]
        [TestCase(new[] { 3, 3 }, 6, new[] {0,1})]
        [TestCase(new[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11, new[] {5,11})]
        public void Test1(int[] nums, int target, int[] expected)
		{
			var actual = new _1().TwoSum(nums,target);
			Assert.AreEqual(expected, actual);

		}
	}
}
