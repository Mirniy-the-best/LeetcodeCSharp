namespace Leetcode.Test
{
	[TestFixture]
	public class _1347_Tests
	{

		[Test]
		[TestCase("bab","aba", 1)]
        [TestCase("babb", "abab", 1)]
        [TestCase("leetcode", "practice", 5)]
		[TestCase("anagram","mangaar", 0)]
		public void Test1(string s, string t , int expected)
		{
			var actual = new _1347().MinSteps(s,t);
			Assert.AreEqual(expected, actual);
		}
	}
}
