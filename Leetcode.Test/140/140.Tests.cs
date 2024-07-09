namespace Leetcode.Test
{
	[TestFixture]
	public class _140_Tests
	{

		[Test]
		[TestCase("catsanddog", new[] { "cat", "cats", "and", "sand", "dog" }, new[] { "cat sand dog", "cats and dog" })]
        [TestCase("pineapplepenapple", new[] { "apple", "pen", "applepen", "pine", "pineapple" }, new[] { "pine apple pen apple", "pine applepen apple", "pineapple pen apple" })]
        [TestCase("catsandog", new[] { "cats", "dog", "sand", "and", "cat" }, new string[0])]
        public void Test1(string s, string[] nums, string[] expected)
		{
			var actual = new _140().WordBreak(s, nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
