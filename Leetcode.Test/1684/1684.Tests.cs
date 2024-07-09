namespace Leetcode.Test
{
	[TestFixture]
	public class _1684_Tests
	{

		[Test]
		[TestCase("ab", new[] { "ad", "bd", "aaab", "baa", "badab" }, 2)]
		[TestCase("abc", new[] { "a", "b", "c", "ab", "ac", "bc", "abc" }, 7)]
		public void Test1(string alloved, string[] nums, int expected)
		{
			var actual = new _1684().CountConsistentStrings(alloved, nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
