namespace Leetcode.Test
{
	[TestFixture]
	public class _162_Tests
	{

		[Test]
        [TestCase(new[] { 2 }, 0)]
        [TestCase(new[] { 2, 1 }, 0)]
        [TestCase(new[] { 1, 2 }, 1)]
		[TestCase(new[] { 1, 2, 3, 1 }, 2)]
		[TestCase(new[] { 1, 2, 1, 3, 5, 6, 4 }, 5)]
		public void Test1(int[] nums, int expected)
		{
			var actual = new _162().FindPeakElement(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
