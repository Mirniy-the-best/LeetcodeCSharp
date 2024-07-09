using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _35_Tests
	{

		[Test]
		[TestCase(new[] { 1, 3, 5, 6 }, 5, 2)]
		[TestCase(new[] { 1, 3, 5, 6 }, 2, 1)]
		[TestCase(new[] { 1, 3, 5, 6 }, 7, 4)]
		public void Test1(int[] nums, int target, int expected)
		{
			var actual = new _35().SearchInsert(nums, target);
			Assert.AreEqual(expected, actual);
		}
	}
}
