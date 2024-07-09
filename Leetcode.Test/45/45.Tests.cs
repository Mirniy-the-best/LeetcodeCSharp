//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _45_Tests
	{

		[Test]
		[TestCase(new[] { 2, 3, 1, 1, 4 }, 2)]
		[TestCase(new[] { 2, 3, 0, 1, 4 }, 2)]
        [TestCase(new[] { 2, 1, 3, 1 }, 2)]
        public void Test1(int[] nums, int expected)
		{
			var actual = new _45().Jump(nums);
			Assert.AreEqual(expected, actual);

		}
	}
}
