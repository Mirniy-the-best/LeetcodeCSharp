namespace Leetcode.Test
{
	[TestFixture]
	public class _881_Tests
	{

		[Test]
		[TestCase(new[] { 1, 2 }, 3, 1)]
		[TestCase(new[] { 3, 2, 2, 1 }, 3, 3)]
		[TestCase(new[] { 3, 5, 3, 4 }, 5, 4)]
		public void Test1(int[] nums, int limit, int expected)
		{
			var actual = new _881().NumRescueBoats(nums, limit);
			Assert.AreEqual(expected, actual);
		}
	}
}
