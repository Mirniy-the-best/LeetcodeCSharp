using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _100157_Tests
	{

		[Test]
		[TestCase(new[] { 1, 2, 3, 2, 5 }, 6)]
		[TestCase(new[] { 3, 4, 5, 1, 12, 14, 13 }, 15)]
        [TestCase(new[] { 3 }, 4)]
        public void Test1(int[] nums, int expected)
		{
			var actual = new _100157().MissingInteger(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
