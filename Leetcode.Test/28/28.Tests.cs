namespace Leetcode.Test
{
	[TestFixture]
	public class _28_Tests
	{

		[Test]
		[TestCase("sadbutsad", "sad", 0)]
		[TestCase("leetcode", "leeto", -1)]
		public void Test1(string s1, string s2, int expected)
		{
			var actual = new _28().StrStr(s1, s2);
			Assert.AreEqual(expected, actual);
		}
	}
}
