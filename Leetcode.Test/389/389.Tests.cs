using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _389_Tests
	{

		[Test]
		[TestCase("abcd","abcde", 'e')]
		[TestCase("","e", 'e')]
		public void Test1(string s1, string s2, char expected)
		{
			var actual = new _389().FindTheDifference(s1, s2);
			Assert.AreEqual(expected, actual);
		}
	}
}
