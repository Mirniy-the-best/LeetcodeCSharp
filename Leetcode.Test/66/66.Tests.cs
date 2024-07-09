using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _66_Tests
	{

		[Test]
		[TestCase(new[] { 1, 2, 3 }, new[] { 1, 2, 4 })]
		[TestCase(new[] { 4, 3, 2, 1 }, new[] { 4, 3, 2, 2 })]
        [TestCase(new[] { 9 }, new[] { 1, 0 })]
        public void Test1(int[] nums, int[] expected)
		{
			var actual = new _66().PlusOne(nums);
			Assert.AreEqual(expected, actual);

		}
	}
}
