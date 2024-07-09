namespace Leetcode.Test
{
	[TestFixture]
	public class _680_Tests
	{

		[Test]
		[TestCase("aba", true)]
		[TestCase("abca", true)]
        [TestCase("abc", false)]
		[TestCase("aguokepatgbnvfqmgmlcupuufxoohdfpgjdmysgvhmvffcnqxjjxqncffvmhvgsymdjgpfdhooxfuupuculmgmqfvnbgtapekouga", true)]
        public void Test1(string nums, bool expected)
		{
			var actual = new _680().ValidPalindrome(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
