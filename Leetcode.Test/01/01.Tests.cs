namespace Leetcode.Test
{
	[TestFixture]
	public class _01_Tests
	{

		[Test]
		[TestCase(new[] { 1, 2, 3, 12 }, 6)]
		[TestCase(new[] { 5, 4, 3 }, 12)]
		[TestCase(new[] { 10, 3, 1, 1 }, 12)]
		public void Test1(int[] nums, int expected)
		{
			var actual = new _01().MinimumCost(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
