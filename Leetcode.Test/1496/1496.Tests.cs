using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _1496_Tests
	{

		[Test]
		[TestCase("NES", false)]
		[TestCase("NESWW", true)]
		public void Test1(string nums, bool expected)
		{
			var actual = new _1496().IsPathCrossing(nums);
			Assert.AreEqual(expected, actual);

		}
	}
}
