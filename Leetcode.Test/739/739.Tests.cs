namespace Leetcode.Test
{
	[TestFixture]
	public class _739_Tests
	{

		[Test]
		[TestCase(new[] { 73, 74, 75, 71, 69, 72, 76, 73 }, new[] { 1, 1, 4, 2, 1, 1, 0, 0 })]
		[TestCase(new[] { 30, 40, 50, 60 }, new[] { 1, 1, 1, 0 })]
        [TestCase(new[] { 30, 60, 90 }, new[] { 1, 1, 0 })]
        public void Test1(int[] nums, int[] expected)
		{
			var actual = new _739().DailyTemperatures(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
