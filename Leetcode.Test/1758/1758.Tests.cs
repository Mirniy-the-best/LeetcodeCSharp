using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _1758_Tests
	{

		[Test]
		[TestCase("0100", 1)]
		[TestCase("10", 0)]
        [TestCase("1111", 2)]
        public void Test1(string nums, int expected)
		{
			var actual = new _1758().MinOperations(nums);
			Assert.AreEqual(expected, actual);

		}
	}
}
