using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _274_Tests
	{

		[Test]
		[TestCase(new[] { 3, 0, 6, 1, 5 }, 3)]
		[TestCase(new[] { 1, 3, 1 }, 1)]
        [TestCase(new[] { 100 }, 1)]
		[TestCase(new[] { 11, 15 }, 2)]
		[TestCase(new[] { 4, 4, 0, 0 }, 2)]
        [TestCase(new[] { 1, 7, 9, 4 }, 3)]
        public void Test1(int[] nums, int expected)
		{
			var actual = new _274().HIndex(nums);
			Assert.AreEqual(expected, actual);

		}
	}
}
