namespace Leetcode.Test
{
	[TestFixture]
	public class _976_Tests
	{

		[Test]
		[TestCase(new[] { 2, 1, 2 }, 5)]
		[TestCase(new[] { 1, 2, 1, 10 }, 0)]
		public void Test1(int[] nums, int expected)
		{
			var actual = new _976().LargestPerimeter(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
