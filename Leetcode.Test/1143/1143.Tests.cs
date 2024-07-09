namespace Leetcode.Test
{
	[TestFixture]
	public class _1143_Tests
	{

		[Test]
		[TestCase("abcba", "abcbcba", 5)]
		[TestCase("bsbininm", "jmjkbkjkv", 1)]
		[TestCase("pmjghexybyrgzczy", "hafcdqbgncrcbihkd", 4)]
		[TestCase("oxcpqrsvwf", "shmtulqrypy", 2)]
		[TestCase("abcde","ace", 3)]
		[TestCase("abc", "abc", 3)]
        [TestCase("abc", "def", 0)]
        [TestCase("ezupkr", "ubmrapg", 2)]
        [TestCase("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", 210)]
        public void Test1(string text1, string text2, int expected)
		{
			var actual = new _1143().LongestCommonSubsequence(text1, text2);
			Assert.AreEqual(expected, actual);
		}
	}
}
