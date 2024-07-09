namespace Leetcode.Test
{
	[TestFixture]
	public class _2000_Tests
	{

		[Test]
		[TestCase("abcdefd", 'd', "dcbaefd")]
        [TestCase("xyxzxe", 'z', "zxyxxe")]
        [TestCase("abcd", 'z', "abcd")]
        public void Test1(string word, char ch, string expected)
		{
			var actual = new _2000().ReversePrefix(word, ch);
			Assert.AreEqual(expected, actual);
		}
	}
}
