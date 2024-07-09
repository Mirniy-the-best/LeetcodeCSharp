using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _1913_Tests
	{

		[Test]
		[TestCase(new[] { 5, 6, 2, 7, 4 }, 34)]
		[TestCase(new[] { 4, 2, 5, 9, 7, 4, 8 }, 64)]
		public void Test1(int[] nums, int expected)
		{
			var actual = new _1913().MaxProductDifference(nums);
			Assert.AreEqual(expected, actual);

		}
	}
}
