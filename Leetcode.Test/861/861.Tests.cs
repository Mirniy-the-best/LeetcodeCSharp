namespace Leetcode.Test
{
	[TestFixture]
	public class _861_Tests
	{

		[Test]
		public void Test1()
		{
			int[][] grid = [[0, 0, 1, 1], [1, 0, 1, 0], [1, 1, 0, 0]];
			var expected = 39;

            var actual = new _861().MatrixScore(grid);
			Assert.AreEqual(expected, actual);
		}

        [Test]
        public void Test2()
        {
            int[][] grid = [[0]];
            var expected = 1;

            var actual = new _861().MatrixScore(grid);
            Assert.AreEqual(expected, actual);
        }

    }
}
