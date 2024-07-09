using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _26_Tests
	{

		[Test]
		[TestCase(new[] { 1, 1, 2 }, 2)]
		[TestCase(new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
        [TestCase(new[] { 0 }, 1)]
        [TestCase(new[] { 1, 2, 3 }, 3)]
        public void Test1(int[] nums, int expected)
		{
			var actual = new _26().RemoveDuplicates(nums);
			Assert.AreEqual(expected, actual);

		}
	}
}
