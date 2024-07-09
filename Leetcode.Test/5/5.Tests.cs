namespace Leetcode.Test
{
	[TestFixture]
	public class _5_Tests
	{

		[Test]
		[TestCase("babad", "bab")]
		[TestCase("cbbd", "bb")]
		public void Test1(string nums, string expected)
		{
			var actual = new _5().LongestPalindrome(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
