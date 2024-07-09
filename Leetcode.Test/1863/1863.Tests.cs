namespace Leetcode.Test
{
	[TestFixture]
	public class _1863_Tests
	{

		[Test]
		[TestCase(new[] { 1, 3 }, 6)]
		[TestCase(new[] { 5, 1, 6 }, 28)]
		[TestCase(new[] { 3, 4, 5, 6, 7, 8 }, 480)]
		public void Test1(int[] nums, int expected)
		{
			var actual = new _1863().SubsetXORSum(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
