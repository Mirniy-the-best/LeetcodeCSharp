namespace Leetcode.Test
{
	[TestFixture]
	public class _1239_Tests
	{

		[Test]
		[TestCase(new[] { "aa", "bb" }, 0)]
		[TestCase(new[] { "un", "iq", "ue" }, 4)]
		[TestCase(new[] { "cha", "r", "act", "ers" }, 6)]
		[TestCase(new[] { "abcdefghijklmnopqrstuvwxyz" }, 26)]
		public void Test1(string[] nums, int expected)
		{
			var actual = new _1239().MaxLength(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
