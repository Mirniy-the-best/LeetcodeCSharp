namespace Leetcode.Test
{
	[TestFixture]
	public class _198_Tests
	{

		[Test]
		[TestCase(new[] { 1, 2, 3, 1 }, 4	)]
		[TestCase(new[] { 2, 7, 9, 3, 1 }, 12)]
		public void Test1(int[] nums, int expected)
		{
			var actual = new _198().Rob(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
