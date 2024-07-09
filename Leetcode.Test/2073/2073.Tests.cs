namespace Leetcode.Test
{
	[TestFixture]
	public class _2073_Tests
	{

		[Test]
		[TestCase(new[] { 2, 3, 2 }, 2,6 )]
		[TestCase(new[] { 5, 1, 1, 1 }, 0, 8)]
		public void Test1(int[] nums, int k, int expected)
		{
			var actual = new _2073().TimeRequiredToBuy(nums, k);
			Assert.AreEqual(expected, actual);
		}
	}
}
