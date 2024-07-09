namespace Leetcode.Test
{
	[TestFixture]
	public class _3110_Tests
	{

		[Test]
		[TestCase("hello", 13)]
		[TestCase("zaz", 50)]
		public void Test1(string nums, int expected)
		{
			var actual = new _3110().ScoreOfString(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
