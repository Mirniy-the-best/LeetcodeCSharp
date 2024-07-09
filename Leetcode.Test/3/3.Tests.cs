using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _3_Tests
	{

		[Test]
		[TestCase("abcabcbb", 3)]
		[TestCase("bbbbb", 1)]
		[TestCase("pwwkew", 3)]
        [TestCase("", 0)]
        public void Test1(string nums, int expected)
		{
			var actual = new _3().LengthOfLongestSubstring(nums);
			Assert.AreEqual(expected, actual);

		}
	}
}
