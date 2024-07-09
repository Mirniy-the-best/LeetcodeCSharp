using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _80_Tests
	{

		[Test]
		[TestCase(new[] { 1, 1, 1, 2, 2, 3 }, 5)]
		[TestCase(new[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 }, 7)]
        [TestCase(new[] { 0 }, 1)]
        public void Test1(int[] nums, int expected)
		{
			var actual = new _80().RemoveDuplicates(nums);
			Assert.AreEqual(expected, actual);

		}
	}
}
