using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _2125_Tests
	{

		[Test]
		[TestCase(new[] { "011001", "000000", "010100", "001000" }, 8)]
		[TestCase(new[] { "000", "111", "000" }, 0)]
		public void Test1(string[] nums, int expected)
		{
			var actual = new _2125().NumberOfBeams(nums);
			Assert.AreEqual(expected, actual);

		}
	}
}
