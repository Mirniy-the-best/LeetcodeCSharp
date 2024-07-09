namespace Leetcode.Test
{
	[TestFixture]
	public class _349_Tests
	{

		[Test]
		[TestCase(new[] { 1, 2, 2, 1 }, new[] { 2, 2 }, new[] { 2 })]
        [TestCase(new[] { 4, 9, 5 }, new[] { 9, 4, 9, 8, 4 }, new[] { 4, 9 })]
        [TestCase(new[] { 1,2 }, new[] { 1,1}, new[] { 1 })]
        public void Test1(int[] nums1, int[] nums2, int[] expected)
		{
			var actual = new _349().Intersection(nums1, nums2);
			Assert.AreEqual(expected, actual);
		}
	}
}
