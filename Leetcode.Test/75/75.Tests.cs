namespace Leetcode.Test
{
	[TestFixture]
	public class _75_Tests
	{

		[Test]
		[TestCase(new[] { 2, 0, 2, 1, 1, 0 }, new[] { 0, 0, 1, 1, 2, 2 })]
		[TestCase(new[] { 2, 0, 1 }, new[] { 0, 1, 2 })]
		[TestCase(new[] { 1, 2, 0 }, new[] { 0, 1, 2 })]
		[TestCase(new[] { 1, 0, 0 }, new[] { 0, 0, 1 })]
		public void Test1(int[] nums, int[] expected)
		{
			new _75().SortColors(nums);
			Assert.AreEqual(expected, nums);
		}
	}
}
