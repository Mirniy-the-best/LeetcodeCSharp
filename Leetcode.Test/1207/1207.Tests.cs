using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _1207_Tests
	{

		[Test]
		[TestCase(new[] { 1, 2, 2, 1, 1, 3 }, true)]
		[TestCase(new[] { 1, 2 }, false)]
        [TestCase(new[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 }, true)]
        public void Test1(int[] nums, bool expected)
		{
			var actual = new _1207().UniqueOccurrences(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
