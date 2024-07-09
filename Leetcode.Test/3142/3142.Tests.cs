namespace Leetcode.Test
{
	[TestFixture]
	public class _3142_Tests
    {

		[Test]
		public void Test1()
		{
			int[][] grid = [[1, 0, 2], [1, 0, 2]];

            var actual = new _3142().SatisfiesConditions(grid);
			Assert.AreEqual(true, actual);
		}


        [Test]
        public void Test2()
        {
            int[][] grid = [[1, 1, 1], [0, 0, 0]];

            var actual = new _3142().SatisfiesConditions(grid);
            Assert.AreEqual(false, actual);
        }

        [Test]
        public void Test3()
        {
            int[][] grid = [[1], [2], [3]];

            var actual = new _3142().SatisfiesConditions(grid);
            Assert.AreEqual(false, actual);
        }

    }
}
