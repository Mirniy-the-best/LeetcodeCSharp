using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _1637_Tests
	{
        [Test]
		public void Test1()
		{
            int[][] points = [[8, 7], [9, 9], [7, 4], [9, 7]];
			int expected = 1;

            var actual = new _1637().MaxWidthOfVerticalArea(points);
			Assert.AreEqual(expected, actual);
		}

        [Test]
        public void Test2()
        {
            int[][] points = [[3, 1], [9, 0], [1, 0], [1, 4], [5, 3], [8, 8]];
            int expected = 3;

            var actual = new _1637().MaxWidthOfVerticalArea(points);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3()
        {
            int[][] points = [[3, 1], [3, 0]];
            int expected = 0;

            var actual = new _1637().MaxWidthOfVerticalArea(points);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test5()
        {
            int[][] points = [[3, 1], [2, 0]];
            int expected = 1;

            var actual = new _1637().MaxWidthOfVerticalArea(points);
            Assert.AreEqual(expected, actual);
        }
    }
}
