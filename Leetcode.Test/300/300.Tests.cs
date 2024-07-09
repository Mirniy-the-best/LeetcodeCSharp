namespace Leetcode.Test
{
	[TestFixture]
	public class _300_Tests
	{

		[Test]
		[TestCase(new[] { 10, 9, 2, 5, 3, 7, 101, 18 }, 4)]
		[TestCase(new[] { 0, 1, 0, 3, 2, 3 }, 4)]
        [TestCase(new[] { 7, 7, 7, 7, 7, 7, 7 }, 1)]
        [TestCase(new[] { 3, 5, 6, 2, 5, 4, 19, 5, 6, 7, 12 }, 6)]
        public void Test1(int[] nums, int expected)
		{
			var actual = new _300().LengthOfLIS(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
