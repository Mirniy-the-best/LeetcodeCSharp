using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _42_Tests
	{

		[Test]
		[TestCase(new[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }, 6)]
		[TestCase(new[] { 4, 2, 0, 3, 2, 5 }, 9)]
        [TestCase(new[] { 4 }, 0)]
        [TestCase(new[] { 4, 2 }, 0)]
        [TestCase(new[] { 4, 2, 1 }, 0)]
        [TestCase(new[] { 4, 2, 3 }, 1)]
        public void Test1(int[] nums, int expected)
		{
			var actual = new _42().Trap(nums);
			Assert.AreEqual(expected, actual);

		}
	}
}
