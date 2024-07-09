using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _383_Tests
	{

		[Test]
		[TestCase("a","b", false)]
        [TestCase("aa", "ab", false)]
        [TestCase("aa", "aab", true)]
        public void Test1(string ransomNote, string magazine , bool expected)
		{
			var actual = new _383().CanConstruct(ransomNote, magazine);
			Assert.AreEqual(expected, actual);
		}
	}
}
