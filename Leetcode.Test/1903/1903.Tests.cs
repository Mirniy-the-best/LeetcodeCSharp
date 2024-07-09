//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _1903_Tests
	{

		[Test]
		[TestCase("52", "5")]
		[TestCase("4206", "")]
		[TestCase("35427", "35427")]
		public void Test1(string nums, string expected)
		{
			var actual = new _1903().LargestOddNumber(nums);
			Assert.AreEqual(expected, actual);

		}
	}
}
