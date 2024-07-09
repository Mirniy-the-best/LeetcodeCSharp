namespace Leetcode.Test
{
	[TestFixture]
	public class _13_Tests
	{

		[Test]
		[TestCase("III", 3)]
		[TestCase("LVIII", 58)]
		[TestCase("MCMXCIV", 1994)]
		public void Test1(string nums, int expected)
		{
			var actual = new _13().RomanToInt(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
