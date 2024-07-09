namespace Leetcode.Test
{
	[TestFixture]
	public class _334_Tests
	{

		[Test]
		[TestCase(new[] { 1, 2, 2, 1 }, false)]
		[TestCase(new[] { 20, 100, 10, 12, 5, 13 },true)]
		[TestCase(new[] { 1, 2, 3, 4, 5 },true)]
		[TestCase(new[] { 5, 4, 3, 2, 1 }, false)]
        [TestCase(new[] { 2, 1, 5, 0, 4, 6 }, true)]
        public void Test1(int[] nums, bool expected)
		{
			var actual = new _334().IncreasingTriplet(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
