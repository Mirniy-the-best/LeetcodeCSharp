using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _219_Tests
	{

		[Test]
		[TestCase(new[] { 1, 2, 3, 1 }, 3,true)]
		[TestCase(new[] { 1, 0, 1, 1 }, 1, true)]
        [TestCase(new[] { 1, 2, 3, 1, 2, 3 }, 2, false)]
        public void Test1(int[] nums, int k, bool expected)
		{
			var actual = new _219().ContainsNearbyDuplicate(nums, k);
			Assert.AreEqual(expected, actual);
		}
	}
}
