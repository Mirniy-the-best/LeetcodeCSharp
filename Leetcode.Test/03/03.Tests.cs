namespace Leetcode.Test
{
	[TestFixture]
	public class _03_Tests
	{

		[Test]

		[TestCase(new[] { 75, 34, 30}, false)]
		[TestCase(new[] { 8, 4, 2, 30, 15 }, true)]
		[TestCase(new[] { 1, 2, 3, 4, 5 }, true)]
		[TestCase(new[] { 3, 16, 8, 4, 2 }, false)]
		public void Test1(int[] nums, bool expected)
		{
			var actual = new _03().CanSortArray(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
