namespace Leetcode.Test
{
	[TestFixture]
	public class _1051_Tests
	{

		[Test]
		[TestCase(new[] { 1, 1, 4, 2, 1, 3 }, 3)]
		[TestCase(new[] { 5, 1, 2, 3, 4 }, 5)]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 0)]
        public void Test1(int[] nums, int expected)
		{
			var actual = new _1051().HeightChecker(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
