namespace Leetcode.Test
{
	[TestFixture]
	public class _648_Tests
	{

		[Test]
		[TestCase(new[] { "cat", "bat", "rat" }, "the cattle was rattled by the battery", "the cat was rat by the bat")]
		[TestCase(new[] { "a", "b", "c" }, "aadsfasf absbs bbab cadsfafs", "a a b c")]
		public void Test1(IList<string> nums, string sentence, string expected)
		{
			var actual = new _648().ReplaceWords(nums, sentence);
			Assert.AreEqual(expected, actual);
		}
	}
}
