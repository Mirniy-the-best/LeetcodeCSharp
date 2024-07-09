namespace Leetcode.Test
{
	[TestFixture]
	public class _2462_Tests
	{

		[Test]
        [TestCase(new[] { 55 }, 1, 1, 55)]
        [TestCase(new[] { 60, 87, 94, 42, 12, 60 }, 5, 4, 261)]
        [TestCase(new[] { 55, 93 }, 1, 1, 55)]
        [TestCase(new[] { 60, 66, 17, 17, 35, 46, 77, 7, 15, 38, 35, 61, 90, 34, 29, 68, 35, 9, 18, 82, 78, 40, 8, 71, 2, 59, 70, 12, 88, 73, 12, 55, 88, 59, 71, 49, 47, 46, 65, 37, 24, 75, 81, 54, 39, 70 }, 37, 40, 1480)]
        [TestCase(new[] { 18, 64, 12, 21, 21, 78, 36, 58, 88, 58, 99, 26, 92, 91, 53, 10, 24, 25, 20, 92, 73, 63, 51, 65, 87, 6, 17, 32, 14, 42, 46, 65, 43, 9, 75 }, 13, 23, 223)]
		[TestCase(new[] { 17, 12, 10, 2, 7, 2, 11, 20, 8 }, 3, 4, 11)]
		[TestCase(new[] { 1, 2, 4, 1 }, 3,3,4)]
		[TestCase(new[] { 31, 25, 72, 79, 74, 65, 84, 91, 18, 59, 27, 9, 81, 33, 17, 58 }, 11, 2, 423)]
		public void Test1(int[] nums, int k, int candidates, int expected)
		{
			var actual = new _2462().TotalCost(nums, k, candidates);
			Assert.AreEqual(expected, actual);
		}
	}
}
