using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _2870_Tests
	{

		[Test]
		[TestCase(new[] { 2, 3, 3, 2, 2, 4, 2, 3, 4 }, 4)]
		[TestCase(new[] { 2, 1, 2, 2, 3, 3 }, -1)]
		public void Test1(int[] nums, int expected)
		{
			var actual = new _2870().MinOperations(nums);
			Assert.AreEqual(expected, actual);

		}
	}
}
