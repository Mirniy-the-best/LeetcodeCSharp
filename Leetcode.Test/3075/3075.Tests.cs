namespace Leetcode.Test
{
	[TestFixture]
	public class _3075_Tests
	{

		[Test]
		[TestCase(new[] { 1, 2, 3 }, 2, 4)]
		[TestCase(new[] { 1, 1, 1, 1 }, 2, 1)]
		[TestCase(new[] { 2, 3, 4, 5 }, 1, 5)]
		public void Test1(int[] nums, int k, int expected)
		{
			var actual = new _3075().MaximumHappinessSum(nums, k);
			Assert.AreEqual(expected, actual);
		}
	}
}
