namespace Leetcode.Test
{
	[TestFixture]
	public class _2390_Tests
	{

		[Test]
		[TestCase("leet**cod*e", "lecoe")]
		[TestCase("erase*****", "")]
		public void Test1(string s, string expected)
		{
			var actual = new _2390().RemoveStars(s);
			Assert.AreEqual(expected, actual);
		}
	}
}
