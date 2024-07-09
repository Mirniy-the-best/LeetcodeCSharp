namespace Leetcode.Test
{
	[TestFixture]
	public class _2824_Tests
	{

		[Test]
		[TestCase(new[] { -1, 1, 2, 3, 1 },2, 3)]
		[TestCase(new[] { -6, 2, 5, -2, -7, -1, 3 }, -2, 10)]
		public void Test1(int[] nums, int target, int expected)
		{
			var actual = new _2824().CountPairs(nums.ToList(), target);
			Assert.AreEqual(expected, actual);
		}
	}
}
