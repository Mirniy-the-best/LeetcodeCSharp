namespace Leetcode.Test
{
	[TestFixture]
	public class _912_Tests
	{

		[Test]
		[TestCase(new[] { 5, 2, 3, 1 }, new[] { 1, 2, 3, 5 })]
		[TestCase(new[] { 5, 1, 1, 2, 0, 0 }, new[] { 0, 0, 1, 1, 2, 5 })]
		public void Test1(int[] nums, int[] expected)
		{
			var actual = new _912().SortArray(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
