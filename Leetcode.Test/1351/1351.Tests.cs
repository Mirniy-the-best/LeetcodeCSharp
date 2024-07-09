namespace Leetcode.Test
{
	[TestFixture]
	public class _1351_Tests
	{

		[Test]
		public void Test1()
		{
			int[][] grid = [[4, 3, 2, -1], [3, 2, 1, -1], [1, 1, -1, -2], [-1, -1, -2, -3]];
			int expected = 8;

            var actual = new _1351().CountNegatives(grid);
			Assert.AreEqual(expected, actual);
		}

        [Test]
        public void Test2()
        {
            int[][] grid = [[3, 2], [1, 0]];
            int expected = 0;

            var actual = new _1351().CountNegatives(grid);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3()
        {
            int[][] grid = [[1, -1], [-1, -1]];
            int expected = 3;

            var actual = new _1351().CountNegatives(grid);
            Assert.AreEqual(expected, actual);
        }

    }
}
