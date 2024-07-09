using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _91_Tests
	{

		[Test]
        [TestCase("27", 1)]
        [TestCase("1", 1)]
        [TestCase("12", 2)]
		[TestCase("226", 3)]
		[TestCase("06", 0)]
        [TestCase("11106", 2)]
        [TestCase("111006", 0)]
        public void Test1(string nums, int expected)
		{
			var actual = new _91().NumDecodings(nums);
			Assert.AreEqual(expected, actual);

		}
	}
}
