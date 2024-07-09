using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _55_Tests
	{

		[Test]
		[TestCase(new[] { 0, 2, 3 }, false)]
		[TestCase(new[] { 2, 3, 1, 1, 4 }, true)]
		[TestCase(new[] { 3, 2, 1, 0, 4 }, false)]
		public void Test1(int[] nums, bool expected)
		{
			var actual = new _55().CanJump(nums);
			Assert.AreEqual(expected, actual);

		}
	}
}
