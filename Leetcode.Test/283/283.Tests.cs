using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _283_Tests
	{

		[Test]
		[TestCase(new[] { 0, 1, 0, 3, 12 }, new[] { 1, 3, 12, 0, 0 })]
		[TestCase(new[] {0 }, new[] { 0 })]
        [TestCase(new[] { 1,2 }, new[] { 1,2 })]
        public void Test1(int[] nums, int[] expected)
		{
			new _283().MoveZeroes(nums);

			Assert.AreEqual(true, Enumerable.SequenceEqual(nums, expected));
		}
	}
}
