namespace Leetcode.Test
{
	[TestFixture]
	public class _2373_Tests
	{

		[Test]
		public void Test1()
		{
			int[][] grid = [[1, 1, 1, 1, 1], [1, 1, 1, 1, 1], [1, 1, 2, 1, 1], [1, 1, 1, 1, 1], [1, 1, 1, 1, 1]];
			int[][] expected = [[2, 2, 2], [2, 2, 2], [2, 2, 2]];

            var actual = new _2373().LargestLocal(grid);
			Assert.AreEqual(expected, actual);
		}

        [Test]
        public void Test2()
        {
            int[][] grid = [[9, 9, 8, 1], [5, 6, 2, 6], [8, 2, 6, 4], [6, 2, 2, 2]];
            int[][] expected = [[9, 9], [8, 6]];

            var actual = new _2373().LargestLocal(grid);
            Assert.AreEqual(expected, actual);
        }

    }
}
