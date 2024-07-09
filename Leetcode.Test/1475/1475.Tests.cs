namespace Leetcode.Test
{
	[TestFixture]
	public class _1475_Tests
	{

		[Test]
		[TestCase(new[] { 8, 4, 6, 2, 3 }, new[] { 4, 2, 4, 2, 3 })]
		[TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 })]
        [TestCase(new[] { 10, 1, 1, 6 }, new[] { 9, 0, 1, 6 })]
        public void Test1(int[] nums, int[] expected)
		{
			var actual = new _1475().FinalPrices(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
