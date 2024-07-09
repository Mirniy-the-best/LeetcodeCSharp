namespace Leetcode.Test
{
	[TestFixture]
	public class _136_Tests
	{

		[Test]
		[TestCase(new[] { 2, 2, 1 }, 1)]
		[TestCase(new[] { 4, 1, 2, 1, 2 }, 4)]
        [TestCase(new[] { 1 }, 1)]
        public void Test1(int[] nums, int expected)
		{
			var actual = new _136().SingleNumber(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
