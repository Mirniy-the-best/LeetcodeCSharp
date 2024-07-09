namespace Leetcode.Test
{
	[TestFixture]
	public class _14_Tests
	{

		[Test]
		[TestCase(new[] { "ab", "a" }, "a")]
		[TestCase(new[] { "flower", "flow", "flight" }, "fl")]
		[TestCase(new[] { "dog", "racecar", "car" }, "")]
		public void Test1(string[] nums, string expected)
		{
			var actual = new _14().LongestCommonPrefix(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
