using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _167_Tests
	{

		[Test]
        [TestCase(new[] { 5, 25, 75 }, 100, new[] { 2, 3 })]
        [TestCase(new[] { 2, 7, 11, 15 }, 9, new[] { 1, 2 } )]
        [TestCase(new[] { 2, 3, 4 }, 6, new[] { 1, 3 })]
        [TestCase(new[] { -1, 0 }, -1, new[] { 1, 2 })]
        public void Test1(int[] nums, int target, int[] expected)
		{
			var actual = new _167().TwoSum(nums, target);
			Assert.AreEqual(expected, actual);

		}
	}
}
