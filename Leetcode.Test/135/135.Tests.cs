using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _135_Tests
	{

		[Test]
		[TestCase(new[] { 1, 0, 2 }, 5)]
		[TestCase(new[] { 1, 2, 2 }, 4)]
		public void Test1(int[] nums, int expected)
		{
			var actual = new _135().Candy(nums);
			Assert.AreEqual(expected, actual);

		}
	}
}
