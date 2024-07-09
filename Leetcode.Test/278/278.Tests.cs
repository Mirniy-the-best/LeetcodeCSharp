using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _278_Tests
	{

		[Test]
		[TestCase(5, 4)]
		[TestCase(1, 1)]
        [TestCase(5, 5)]
        [TestCase(5, 0)]
        [TestCase(6, 4)]
        [TestCase(6, 3)]
		[TestCase(2126753390, 1702766719)]
        public void Test1(int nums, int expected)
		{
			var c = new _278();
			c.BadVersion = expected;
            var actual = c.FirstBadVersion(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
