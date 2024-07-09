namespace Leetcode.Test
{
	[TestFixture]
	public class _1679_Tests
	{

		[Test]
		[TestCase(new[] { 1, 2, 3, 4 }, 5, 2)]
		[TestCase(new[] { 3, 1, 3, 4, 3 }, 6, 1)]
		[TestCase(new[] { 4, 4, 1, 3, 1, 3, 2, 2, 5, 5, 1, 5, 2, 1, 2, 3, 5, 4 }, 2, 2)]
		[TestCase(new[] { 2, 2, 2, 3, 1, 1, 4, 1 }, 4, 2)]
		public void Test1(int[] nums, int k, int expected)
		{
			var actual = new _1679().MaxOperations(nums, k);
			Assert.AreEqual(expected, actual);
		}
	}
}
