namespace Leetcode.Test
{
	[TestFixture]
	public class _345_Tests
	{

		[Test]
        [TestCase("aA", "Aa")]
        [TestCase("e", "e")]
        [TestCase("h", "h")]
        [TestCase("hr", "hr")]
        [TestCase("ue", "eu")]
        [TestCase("hello", "holle")]
        [TestCase("leetcode", "leotcede")]
		public void Test1(string nums, string expected)
		{
			var actual = new _345().ReverseVowels(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
