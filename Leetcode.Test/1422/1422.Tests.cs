using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _1422_Tests
	{

		[Test]
        [TestCase("1011011", 5)]
        [TestCase("011101", 5)]
		[TestCase("00111", 5)]
        [TestCase("001110", 5)]
        [TestCase("1111", 3)]
        [TestCase("0000", 3)]
        [TestCase("01", 2)]
        public void Test1(string s, int expected)
		{
			var actual = new _1422().MaxScore(s);
			Assert.AreEqual(expected, actual);

		}
	}
}
