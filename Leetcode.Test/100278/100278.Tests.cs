namespace Leetcode.Test
{
	[TestFixture]
	public class _100278_Tests
    {

		[Test]
		public void Test1()
		{
            int[][] grid = [[0, 1, 0], [0, 1, 1], [0, 1, 0]];
            long expected = 2;
            var actual = new _100278().NumberOfRightTriangles(grid);
			Assert.AreEqual(expected, actual);
		}

        [Test]
        public void Test2()
        {
            int[][] grid = [[1, 0, 0, 0], [0, 1, 0, 1], [1, 0, 0, 0]];
            long expected = 0;
            var actual = new _100278().NumberOfRightTriangles(grid);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3()
        {
            int[][] grid = [[1, 0, 1], [1, 0, 0], [1, 0, 0]];
            long expected = 2;
            var actual = new _100278().NumberOfRightTriangles(grid);
            Assert.AreEqual(expected, actual);
        }


    }
}
