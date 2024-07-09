//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _1287_Tests
	{

		[Test]
		[TestCase(new[] { 1, 2, 2, 6, 6, 6, 6, 7, 10 }, 6)]
		[TestCase(new[] { 1, 1 }, 1)]
		public void Test1(int[] nums, int expected)
		{
			var actual = new _1287().FindSpecialInteger(nums);
			Assert.AreEqual(expected, actual);

		}
	}
}
