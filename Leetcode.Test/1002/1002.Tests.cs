namespace Leetcode.Test
{
	[TestFixture]
	public class _1002_Tests
	{

		[Test]
		[TestCase(new[] { "bella", "label", "roller" }, new[] { "e", "l", "l" })]
		[TestCase(new[] { "cool", "lock", "cook" }, new[] { "c", "o" })]
		public void Test1(string[] nums, string[] expected)
		{
			var actual = new _1002().CommonChars(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
