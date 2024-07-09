using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _496_Tests
	{

		[Test]
		[TestCase(new[] { 4, 1, 2 }, new[] { 1, 3, 4, 2 }, new[] { -1, 3, -1 })]
        [TestCase(new[] { 2,4 }, new[] { 1, 2, 3, 4 }, new[] { 3, -1 })]
        public void Test1(int[] nums1, int[] nums2, int[] expected)
		{
			var actual = new _496().NextGreaterElement(nums1, nums2);
			Assert.AreEqual(expected, actual);

		}
	}
}
