namespace Leetcode.Test
{
	[TestFixture]
	public class _945_Tests
	{

		[Test]
		[TestCase(new[] { 2, 2, 2, 1 }, 3)]
		[TestCase(new[] { 0, 2, 2 }, 1)]
		[TestCase(new[] { 1, 2, 2 }, 1)]
		[TestCase(new[] { 3, 2, 1, 2, 1, 7 }, 6)]
		public void Test1(int[] nums, int expected)
		{
			var actual = new _945().MinIncrementForUnique(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
