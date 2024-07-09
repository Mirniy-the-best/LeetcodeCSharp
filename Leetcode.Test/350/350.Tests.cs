namespace Leetcode.Test
{
	[TestFixture]
	public class _350_Tests
	{

		[Test]
		[TestCase(new[] { 1, 2, 2, 1 }, new[] { 2, 2 }, new[] { 2, 2 })]
		[TestCase(new[] { 4, 9, 5 }, new[] { 9, 4, 9, 8, 4 }, new[] { 4, 9 })]
		public void Test1(int[] nums1, int[] nums2, int[] expected)
		{
			var actual = new _350().Intersect(nums1, nums2);
			Assert.AreEqual(expected, actual);
		}
	}
}
