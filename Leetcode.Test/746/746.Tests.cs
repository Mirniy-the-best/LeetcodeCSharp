namespace Leetcode.Test
{
	[TestFixture]
	public class _746_Tests
	{

		[Test]
		[TestCase(new[] { 10, 15, 20 }, 15)]
		[TestCase(new[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 }, 6)]
		public void Test1(int[] nums, int expected)
		{
			var actual = new _746().MinCostClimbingStairs(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
