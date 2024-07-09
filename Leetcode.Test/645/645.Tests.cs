namespace Leetcode.Test
{
	[TestFixture]
	public class _645_Tests
	{

		[Test]
		[TestCase(new[] { 1, 2, 2, 4 }, new[] { 2,3 })]
        [TestCase(new[] { 1, 1 }, new[] { 1, 2 })]
        [TestCase(new[] { 3, 2, 3, 4, 6, 5 }, new[] { 3, 1 })]
        public void Test1(int[] nums, int[] expected)
		{
			var actual = new _645().FindErrorNums(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
