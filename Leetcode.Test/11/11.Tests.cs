using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _11_Tests
	{

		[Test]
		[TestCase(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
		[TestCase(new[] { 1, 1 }, 1)]
		public void Test1(int[] nums, int expected)
		{
			var actual = new _11().MaxArea(nums);
			Assert.AreEqual(expected, actual);

		}
	}
}
