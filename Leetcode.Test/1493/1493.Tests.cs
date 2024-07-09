namespace Leetcode.Test
{
	[TestFixture]
	public class _1493_Tests
	{

		[Test]
		[TestCase(new[] { 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1 }, 18)]
		[TestCase(new[] { 0, 0, 1, 1 }, 2)]
		[TestCase(new[] { 0, 0, 0 }, 0)]
		[TestCase(new[] { 1, 1, 0, 1 }, 3)]
		[TestCase(new[] { 1, 1, 1 }, 2)]
		[TestCase(new[] { 0, 1, 1, 1, 0, 1, 1, 0, 1 }, 5)]
		public void Test1(int[] nums, int expected)
		{
			var actual = new _1493().LongestSubarray(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
