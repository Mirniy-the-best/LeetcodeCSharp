namespace Leetcode.Test
{
	[TestFixture]
	public class _1219_Tests
	{

		[Test]
		public void Test1()
		{
			int[][] grid = [[0, 6, 0], [5, 8, 7], [0, 9, 0]];
			var expected = 24;

            var actual = new _1219().GetMaximumGold(grid);
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Test2()
		{
			int[][] grid = [[1, 0, 7], [2, 0, 6], [3, 4, 5], [0, 3, 0], [9, 0, 20]];
			var expected = 28;

			var actual = new _1219().GetMaximumGold(grid);
			Assert.AreEqual(expected, actual);
		}
	}
}
