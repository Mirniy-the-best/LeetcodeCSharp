namespace Leetcode.Test
{
	[TestFixture]
	public class _2486_Tests
	{

		[Test]
		[TestCase("coaching", "coding", 4)]
		[TestCase("abcde","a", 0)]
        [TestCase("z", "abcde", 5)]
        public void Test1(string s, string t, int expected)
		{
			var actual = new _2486().AppendCharacters(s,t);
			Assert.AreEqual(expected, actual);
		}
	}
}
