namespace Leetcode.Test
{
	[TestFixture]
	public class _238_Tests
	{

		[Test]
		[TestCase(new[] { 1, 2, 3, 4 }, new[] { 24, 12, 8, 6 })]
		[TestCase(new[] { -1, 1, 0, -3, 3 }, new[] { 0, 0, 9, 0, 0 })]
		public void Test1(int[] nums, int[] expected)
		{
			var actual = new _238().ProductExceptSelf(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
