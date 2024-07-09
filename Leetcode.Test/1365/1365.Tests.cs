namespace Leetcode.Test
{
	[TestFixture]
	public class _1365_Tests
	{

		[Test]
		[TestCase(new[] { 8, 1, 2, 2, 3 }, new[] { 4, 0, 1, 1, 3 })]
		[TestCase(new[] { 6, 5, 4, 8 }, new[] { 2, 1, 0, 3 })]
        [TestCase(new[] { 7, 7, 7, 7 }, new[] { 0, 0, 0, 0 })]
        public void Test1(int[] nums, int[] expected)
		{
			var actual = new _1365().SmallerNumbersThanCurrent(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
