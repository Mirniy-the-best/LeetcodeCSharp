namespace Leetcode.Test
{
	[TestFixture]
	public class _1657_Tests
	{

		[Test]
        [TestCase("uau", "ssx", false)]
        [TestCase("abc", "bca", true)]
		[TestCase("a", "aa", false)]
        [TestCase("cabbba", "abbccc", true)]
        public void Test1(string w1, string w2, bool expected)
		{
			var actual = new _1657().CloseStrings(w1, w2);
			Assert.AreEqual(expected, actual);
		}
	}
}
