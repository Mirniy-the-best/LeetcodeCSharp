using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _67_Tests
	{

		[Test]
		[TestCase("11", "1", "100")]
        [TestCase("1010", "1011", "10101")]
        [TestCase("11", "0", "11")]
        [TestCase("0", "11", "11")]
        public void Test1(string a, string b, string expected)
		{
			var actual = new _67().AddBinary(a,b);
			Assert.AreEqual(expected, actual);

		}
	}
}
