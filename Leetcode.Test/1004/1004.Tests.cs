namespace Leetcode.Test
{
	[TestFixture]
	public class _1004_Tests
	{

		[Test]
		[TestCase(new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 }, 2, 6)]
		[TestCase(new[] { 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1 }, 3, 10)]
		public void Test1(int[] nums, int k, int expected)
		{
			var actual = new _1004().LongestOnes(nums, k);
			Assert.AreEqual(expected, actual);
		}
	}
}
