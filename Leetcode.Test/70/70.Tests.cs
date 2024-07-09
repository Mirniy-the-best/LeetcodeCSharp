using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _70_Tests
	{

		[Test]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
		[TestCase(3, 3)]
        [TestCase(45, 1836311903)]
        public void Test1(int nums, int expected)
		{
			var actual = new _70().ClimbStairs(nums);
			Assert.AreEqual(expected, actual);

		}
	}
}
