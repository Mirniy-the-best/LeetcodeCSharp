using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _1578_Tests
	{

		[Test]
		[TestCase("abaac", new[] { 1, 2, 3, 4, 5 }, 3)]
		[TestCase("abc", new[] { 1, 2, 3 }, 0)]
		[TestCase("aabaa", new[] { 1, 2, 3, 4, 1 }, 2)]
		public void Test1(string colors , int[] nums, int expected)
		{
			var actual = new _1578().MinCost(colors , nums);
			Assert.AreEqual(expected, actual);

		}
	}
}
