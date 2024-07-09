namespace Leetcode.Test
{
	[TestFixture]
	public class _2352_Tests
	{

		[Test]
		public void Test1()
		{
			int[][] grid = [[3, 2, 1], [1, 7, 6], [2, 7, 7]];
			var expected = 1;

            var actual = new _2352().EqualPairs(grid);
			Assert.AreEqual(expected, actual);
		}

        [Test]
        public void Test2()
        {
            int[][] grid = [[3, 1, 2, 2], [1, 4, 4, 5], [2, 4, 2, 2], [2, 4, 2, 2]];
            var expected = 3;

            var actual = new _2352().EqualPairs(grid);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3()
        {
            int[][] grid = [[13, 13], [13, 13]];
            var expected = 4;

            var actual = new _2352().EqualPairs(grid);
            Assert.AreEqual(expected, actual);
        }

    }
}
