namespace Leetcode.Test
{
	[TestFixture]
	public class _2997_Tests
	{

		[Test]
		[TestCase(new[] { 2, 1, 3, 4 }, 1, 2)]
		[TestCase(new[] { 2, 0, 2, 0 }, 0, 0)]
		public void Test1(int[] nums, int k, int expected)
		{
			var actual = new _2997().MinOperations(nums,k);
			Assert.AreEqual(expected, actual);
		}
	}
}
