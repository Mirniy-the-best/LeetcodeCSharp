using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _724_Tests
	{

		[Test]
		[TestCase(new[] { 1, 7, 3, 6, 5, 6 }, 3)]
		[TestCase(new[] { 1, 2, 3 }, -1)]
        [TestCase(new[] { 2, 1, -1 }, 0)]
        public void Test1(int[] nums, int expected)
		{
			var actual = new _724().PivotIndex(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
