namespace Leetcode.Test
{
	[TestFixture]
	public class _1208_Tests
	{

		[Test]
		[TestCase("abcd", "bcdf",  3, 3)]
        [TestCase("abcd", "cdef", 3, 1)]
        [TestCase("abcd", "acde", 0, 1)]
        [TestCase("anryddgaqpjdw", "zjhotgdlmadcf", 5, 1)]
        public void Test1(string s1, string s2, int cost, int expected)
		{
			var actual = new _1208().EqualSubstring(s1,s2,cost);
			Assert.AreEqual(expected, actual);
		}
	}
}
