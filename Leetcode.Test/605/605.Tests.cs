namespace Leetcode.Test
{
	[TestFixture]
	public class _605_Tests
	{

		[Test]
		[TestCase(new[] { 1 }, 0, true)]
		[TestCase(new[] { 1, 0, 0, 0, 1, 0, 0 }, 2, true)]
		[TestCase(new[] { 1, 0, 0, 0, 1 }, 1, true)]
		[TestCase(new[] { 1, 0, 0, 0, 1 }, 2, false)]
		public void Test1(int[] nums, int n, bool expected)
		{
			var actual = new _605().CanPlaceFlowers(nums, n);
			Assert.AreEqual(expected, actual);
		}
	}
}
