namespace Leetcode.Test
{
	[TestFixture]
	public class _786_Tests
	{

		[Test]
		[TestCase(new[] { 1, 2, 3, 5 }, 3, new[] { 2, 5 })]
		[TestCase(new[] { 1, 7 }, 1, new[] { 1, 7 })]
		public void Test1(int[] nums, int k, int[] expected)
		{
			var actual = new _786().KthSmallestPrimeFraction(nums, k);
			Assert.AreEqual(expected, actual);
		}
	}
}
