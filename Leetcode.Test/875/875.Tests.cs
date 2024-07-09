namespace Leetcode.Test
{
	[TestFixture]
	public class _875_Tests
	{

		[Test]
        [TestCase(new[] { 2, 2 }, 4, 1)]
        [TestCase(new[] { 3 }, 5, 1)]
        [TestCase(new[] { 3 }, 1, 3)]
        [TestCase(new[] { 3, 6, 7, 11 }, 8, 4)]
		[TestCase(new[] { 30, 11, 23, 4, 20 }, 5, 30)]
        [TestCase(new[] { 30, 11, 23, 4, 20 }, 6, 23)]
        public void Test1(int[] nums, int h, int expected)
		{
			var actual = new _875().MinEatingSpeed(nums, h);
			Assert.AreEqual(expected, actual);
		}
	}
}
