using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _69_Tests
	{
		[Test]
        [TestCase(2147395600, 46340)]
        [TestCase(2147395599, 46339)]
        [TestCase(48, 6)]
        [TestCase(49, 7)]
        [TestCase(4, 2)]
		[TestCase(8, 2)]
        [TestCase(0, 0)]
        [TestCase(2, 1)]
        public void Test1(int nums, int expected)
		{
			var actual = new _69().MySqrt(nums);
			Assert.AreEqual(expected, actual);

		}
	}
}
