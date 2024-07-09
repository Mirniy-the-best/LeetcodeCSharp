using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _88_Tests
	{
		[Test]
		[TestCase(new[] { 1, 2, 3, 0, 0, 0 }, 3, new[] { 2, 5, 6 }, 3, new[] { 1, 2, 2, 3, 5, 6 })]
        [TestCase(new[] { 1 }, 1, new int[0], 0, new[] { 1 })]
        [TestCase(new[] { 0 }, 0, new[] { 1 }, 1, new[] { 1 })]

        public void Merge(int[] nums1, int m, int[] nums2, int n, int[] expected)
        {
             new _88().Merge(nums1, m, nums2, n);
            Assert.AreEqual(expected, nums1);
        }
    }
}
