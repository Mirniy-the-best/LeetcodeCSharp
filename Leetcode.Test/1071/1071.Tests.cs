namespace Leetcode.Test
{
	[TestFixture]
	public class _1071_Tests
	{

		[Test]
		[TestCase("ABCABC", "ABC", "ABC")]
		[TestCase("ABABAB", "ABAB", "AB")]
		public void Test1(string str1, string str2, string expected)
		{
			var actual = new _1071().GcdOfStrings(str1, str2);
			Assert.AreEqual(expected, actual);
		}
	}
}
