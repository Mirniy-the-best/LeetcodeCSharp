using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _169_Tests
	{

		[Test]
		[TestCase(new[] { 3, 2, 3 }, 3)]
		[TestCase(new[] { 2, 2, 1, 1, 1, 2, 2 }, 2)]
		public void Test1(int[] nums, int expected)
		{
			var actual = new _169().MajorityElement(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
