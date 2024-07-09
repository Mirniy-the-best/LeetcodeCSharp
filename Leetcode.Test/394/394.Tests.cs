namespace Leetcode.Test
{
	[TestFixture]
	public class _394_Tests
	{

		[Test]
		[TestCase("10[le]", "lelelelelelelelelele")]
		[TestCase("abc3[cd]xyz", "abccdcdcdxyz")]
		[TestCase("3[a]2[bc]", "aaabcbc")]
        [TestCase("3[a2[c]]", "accaccacc")]
        [TestCase("2[abc]3[cd]ef", "abcabccdcdcdef")]
        public void Test1(string nums, string expected)
		{
			var actual = new _394().DecodeString(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
