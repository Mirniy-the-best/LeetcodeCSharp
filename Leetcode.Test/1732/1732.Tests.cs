using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _1732_Tests
	{

		[Test]
		[TestCase(new[] { -5, 1, 5, 0, -7 }, 1)]
		[TestCase(new[] { -4, -3, -2, -1, 4, 3, 2 }, 0)]
		public void Test1(int[] nums, int expected)
		{
			var actual = new _1732().LargestAltitude(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
