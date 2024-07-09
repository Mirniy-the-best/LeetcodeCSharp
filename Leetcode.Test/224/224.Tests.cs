using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _224_Tests
	{

		[Test]
		[TestCase("- (3 - (- (4 + 5) ) )", -12)]
		[TestCase("1-(     -2)", 3)]
		[TestCase("1 + 1", 2)]
		[TestCase(" 2-1 + 2 ", 3)]
		[TestCase("(1+(4+5+2)-3)+(6+8)", 23)]
		[TestCase("-(2 + 3)", -5)]
		public void Test1(string nums, int expected)
		{
			var actual = new _224().Calculate(nums);
			Assert.AreEqual(expected, actual);

		}
	}
}
