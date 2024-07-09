namespace Leetcode.Test
{
	[TestFixture]
	public class _3012_Tests
	{

		[Test]
		[TestCase(new[] { 1, 4, 3, 1 }, 1)]
		[TestCase(new[] { 5, 5, 5, 10, 5 }, 2)]
        [TestCase(new[] { 2, 3, 4 }, 1)]
		[TestCase(new[] { 4, 4, 4 }, 2)]
		[TestCase(new[] { 5, 2, 2, 2, 9, 10 }, 1)]
        public void Test1(int[] nums, int expected)
		{
			var actual = new _3012().MinimumArrayLength(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
