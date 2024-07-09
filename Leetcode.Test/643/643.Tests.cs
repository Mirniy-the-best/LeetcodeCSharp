using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _643_Tests
	{

		[Test]
		[TestCase(new[] { 1, 12, -5, -6, 50, 3 }, 4, 12.75000)]
		[TestCase(new[] { 5 }, 1, 5.00000)]
		public void Test1(int[] nums, int k, double expected)
		{
			var actual = new _643().FindMaxAverage(nums, k);
			Assert.AreEqual(expected, actual);
		}
	}
}
