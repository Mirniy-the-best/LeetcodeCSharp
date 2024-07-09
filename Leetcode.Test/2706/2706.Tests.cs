using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _2706_Tests
	{

		[Test]
		[TestCase(new[] { 1, 2, 2 }, 3, 0)]
		[TestCase(new[] { 3, 2, 3 }, 3,  3)]
        [TestCase(new[] { 1, 2, 3 }, 4, 1)]
        public void Test1(int[] nums, int m, int expected)
		{
			var actual = new _2706().BuyChoco(nums, m);
			Assert.AreEqual(expected, actual);

		}
	}
}
