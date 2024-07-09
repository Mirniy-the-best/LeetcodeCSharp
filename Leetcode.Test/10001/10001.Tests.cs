namespace Leetcode.Test
{
	[TestFixture]
	public class _10001_Tests
	{

		[Test]
		[TestCase("abc", "abc")]
		[TestCase("cb34", "")]
		public void Test1(string nums, string expected)
		{
			var actual = new _10001().ClearDigits(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
