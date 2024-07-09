namespace Leetcode.Test
{
	[TestFixture]
	public class _735_Tests
	{

		[Test]
		[TestCase(new[] { 5, 10, -5 }, new[] { 5, 10 })]
		[TestCase(new[] { 8, -8 }, new int[0])]
		[TestCase(new[] { 10, 2, -5 }, new[] {10})]
		[TestCase(new[] { -2, -1, 1, 2 }, new[] { -2, -1, 1, 2 })]
		public void Test1(int[] nums, int[] expected)
		{
			var actual = new _735().AsteroidCollision(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
