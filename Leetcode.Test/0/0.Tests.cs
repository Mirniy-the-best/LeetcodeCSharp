namespace Leetcode.Test
{
	[TestFixture]
	public class _0_Tests
	{

		[Test]
		[TestCase(new[] { 1, 2, 2, 6, 6, 6, 6, 7, 10 }, 0)]
		[TestCase(new[] { 1, 1 }, 0)]
		public void Test1(int[] nums, int expected)
		{
			var actual = new _0().FindSpecialInteger(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
