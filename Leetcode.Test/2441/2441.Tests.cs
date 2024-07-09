namespace Leetcode.Test
{
	[TestFixture]
	public class _2441_Tests
	{

		[Test]
		[TestCase(new[] { -1, 2, -3, 3 }, 3)]
		[TestCase(new[] { -1, 10, 6, 7, -7, 1 }, 7)]
        [TestCase(new[] { -10, 8, 6, 7, -2, -3 }, -1)]
        public void Test1(int[] nums, int expected)
		{
			var actual = new _2441().FindMaxK(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
