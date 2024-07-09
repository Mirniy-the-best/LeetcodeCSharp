namespace Leetcode.Test
{
	[TestFixture]
	public class _2597_Tests
	{

		[Test]
		[TestCase(new[] { 2, 4, 6 }, 2, 4)]
		[TestCase(new[] { 1 }, 1, 1)]
		public void Test1(int[] nums, int k, int expected)
		{
			var actual = new _2597().BeautifulSubsets(nums, k);
			Assert.AreEqual(expected, actual);
		}
	}
}
