namespace Leetcode.Test
{
	[TestFixture]
	public class _1512_Tests
	{

		[Test]
		[TestCase(new[] { 1, 2, 3, 1, 1, 3 }, 4)]
		[TestCase(new[] { 1, 1, 1, 1 }, 6)]
        [TestCase(new[] { 1, 2, 3 }, 0)]
        public void Test1(int[] nums, int expected)
		{
			var actual = new _1512().NumIdenticalPairs(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
