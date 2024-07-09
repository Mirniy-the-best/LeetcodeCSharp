namespace Leetcode.Test
{
	[TestFixture]
	public class _1509_Tests
	{

		[Test]
		[TestCase(new[] { 5, 3, 2, 4 }, 0)]
		[TestCase(new[] { 1, 5, 0, 10, 14 }, 1)]
        [TestCase(new[] { 3, 100, 20 }, 0)]
        [TestCase(new[] { 6, 6, 0, 1, 1, 4, 6 }, 2)]
        public void Test1(int[] nums, int expected)
		{
			var actual = new _1509().MinDifference(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
