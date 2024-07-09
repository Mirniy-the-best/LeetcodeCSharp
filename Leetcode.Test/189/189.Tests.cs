using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _189_Tests
	{

		[Test]
		[TestCase(new[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new[] { 5, 6, 7, 1, 2, 3, 4 })]
		[TestCase(new[] { -1, -100, 3, 99 }, 2, new[] { 3, 99, -1, -100 })]
        [TestCase(new[] { -1}, 2, new[] { -1 })]
        public void Test1(int[] nums,int k, int[] expected)
		{
			new _189().Rotate(nums, k);
			Assert.AreEqual(expected, nums);

		}
	}
}
