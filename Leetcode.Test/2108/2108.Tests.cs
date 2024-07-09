namespace Leetcode.Test
{
	[TestFixture]
	public class _2108_Tests
	{

		[Test]
		[TestCase(new[] { "abc", "car", "ada", "racecar", "cool" }, "ada")]
		[TestCase(new[] { "notapalindrome", "racecar" }, "racecar")]
        [TestCase(new[] { "def", "ghi" }, "")]
        public void Test1(string[] nums, string expected)
		{
			var actual = new _2108().FirstPalindrome(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
