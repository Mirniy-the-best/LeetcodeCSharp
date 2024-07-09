namespace Leetcode.Test
{
	[TestFixture]
	public class _153_Tests
	{

		[Test]
		[TestCase(new[] { 3, 1, 2 }, 1)]
        [TestCase(new[] { 5,3,2,1}, 1)]
        [TestCase(new[] { 1, 2,3,4,5 }, 1)]
        [TestCase(new[] { 3}, 3)]
        [TestCase(new[] { 3, 4, 5, 1, 2 },1)]
		[TestCase(new[] { 4, 5, 6, 7, 0, 1, 2 }, 0)]
        [TestCase(new[] { 11, 13, 15, 17 }, 11)]
        public void Test1(int[] nums, int expected)
		{
			var actual = new _153().FindMin(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
