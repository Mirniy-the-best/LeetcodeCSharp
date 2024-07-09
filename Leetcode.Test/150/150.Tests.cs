namespace Leetcode.Test
{
	[TestFixture]
	public class _150_Tests
	{

		[Test]
		[TestCase(new[] { "2", "1", "+", "3", "*" }, 9)]
		[TestCase(new[] { "4", "13", "5", "/", "+" }, 6)]
        [TestCase(new[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" }, 22)]
        public void Test1(string[] nums, int expected)
		{
			var actual = new _150().EvalRPN(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
