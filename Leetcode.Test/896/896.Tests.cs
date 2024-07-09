using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _896_Tests
	{

		[Test]
		[TestCase(new[] { 1, 2, 2, 3 }, true)]
		[TestCase(new[] { 6, 5, 4, 4 }, true)]
        [TestCase(new[] { 1, 3, 2 }, false)]
        public void Test1(int[] nums, bool expected)
		{
			var actual = new _896().IsMonotonic(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
