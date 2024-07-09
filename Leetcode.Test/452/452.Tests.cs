namespace Leetcode.Test
{
	[TestFixture]
	public class _452_Tests
	{

		[Test]
		public void Test1()
		{
			int[][] points = [[10, 16], [2, 8], [1, 6], [7, 12]];
			int expected = 2;

            var actual = new _452().FindMinArrowShots(points);
			Assert.AreEqual(expected, actual);
		}

        [Test]
        public void Test2()
        {
            int[][] points = [[1, 2], [3, 4], [5, 6], [7, 8]];
            int expected = 4;

            var actual = new _452().FindMinArrowShots(points);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3()
        {
            int[][] points = [[1, 2], [2, 3], [3, 4], [4, 5]];
            int expected = 2;

            var actual = new _452().FindMinArrowShots(points);
            Assert.AreEqual(expected, actual);
        }

    }
}
