namespace Leetcode.Test
{
	[TestFixture]
	public class _1122_Tests
	{

		[Test]
		[TestCase(new[] { 2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19 }, new[] { 2, 1, 4, 3, 9, 6 }, new[] { 2, 2, 2, 1, 4, 3, 3, 9, 6, 7, 19 })]
		[TestCase(new[] { 28, 6, 22, 8, 44, 17 }, new[] { 22, 28, 8, 6 }, new[] { 22, 28, 8, 6, 17, 44 })]
		public void Test1(int[] nums, int[] nums2, int[] expected)
		{
			var actual = new _1122().RelativeSortArray(nums, nums2);
			Assert.AreEqual(expected, actual);
		}
	}
}
