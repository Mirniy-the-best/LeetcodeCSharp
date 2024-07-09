//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _9_Tests
	{

		[Test]
		[TestCase(121, true)]
		[TestCase(-121, false)]
		[TestCase(10, false)]
		public void Test1(int nums, bool expected)
		{
			var actual = new _9().IsPalindrome(nums);
			Assert.AreEqual(expected, actual);

		}
	}
}
