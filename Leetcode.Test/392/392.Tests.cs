namespace Leetcode.Test
{
	[TestFixture]
	public class _392_Tests
	{

		[Test]
		[TestCase("abc", "ahbgdc", true)]
		[TestCase("axc", "ahbgdc", false)]
        [TestCase("", "ahbgdc", true)]
        public void Test1(string s, string t, bool expected)
		{
			var actual = new _392().IsSubsequence(s,t);
			Assert.AreEqual(expected, actual);
		}
	}
}
