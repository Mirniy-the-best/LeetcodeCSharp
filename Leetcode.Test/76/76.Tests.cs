namespace Leetcode.Test
{
	[TestFixture]
	public class _76_Tests
	{

		[Test]
		[TestCase("aaaaaaaaaaaabbbbbcdd", "abcdd", "abbbbbcdd")]
		[TestCase("aaflslflsldkalskaaa", "aaa", "aaa")]
		[TestCase("ADOBECODEBANC", "ABC", "BANC")]
		[TestCase("a","a","a")]
        [TestCase("aa", "aa", "aa")]
        [TestCase("a", "aa", "")]
        [TestCase("ab", "b", "b")]
        public void Test1(string s, string t, string expected)
		{
			var actual = new _76().MinWindow(s,t);
			Assert.AreEqual(expected, actual);
		}
	}
}
