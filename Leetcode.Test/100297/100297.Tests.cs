namespace Leetcode.Test
{
	[TestFixture]
	public class _100297_Tests
    {

		[Test]
		[TestCase(new[] { 4, 2, 6, 3, 9 }, 2, 2)]
		[TestCase(new[] { 2, 5, 4 }, 3,1)]
[TestCase(new[] { 19,3,6,16,10,9,2 }, 422917785, 0)]
		public void Test1(int[] nums, int k, int expected)
		{
			var actual = new _100297().FindWinningPlayer(nums, k);
			Assert.AreEqual(expected, actual);
		}
	}
}
