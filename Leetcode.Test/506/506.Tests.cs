namespace Leetcode.Test
{
	[TestFixture]
	public class _506_Tests
	{

		[Test]
		[TestCase(new[] { 5, 4, 3, 2, 1 }, new[] { "Gold Medal", "Silver Medal", "Bronze Medal", "4", "5" })]
		[TestCase(new[] { 10, 3, 8, 9, 4 }, new[] { "Gold Medal", "5", "Bronze Medal", "Silver Medal", "4" })]
		public void Test1(int[] nums, string[] expected)
		{
			var actual = new _506().FindRelativeRanks(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
