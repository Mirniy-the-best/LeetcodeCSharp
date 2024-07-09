using NUnit.Framework.Constraints;

namespace Leetcode.Test
{
	[TestFixture]
	public class _435_Tests
	{

		[Test]
		public void Test1()
		{
			int[][] intervals = [[1, 2], [2, 3], [3, 4], [1, 3]];
			int expected = 1;

            var actual = new _435().EraseOverlapIntervals(intervals);
			Assert.AreEqual(expected, actual);
		}

        [Test]
        public void Test2()
        {
            int[][] intervals = [[1, 2], [1, 2], [1, 2]];
            int expected = 2;

            var actual = new _435().EraseOverlapIntervals(intervals);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3()
        {
            int[][] intervals = [[1, 2], [2, 3]];
            int expected = 0;

            var actual = new _435().EraseOverlapIntervals(intervals);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test4()
        {
            int[][] intervals = [[1, 2], [2, 3], [3, 4], [-100, -2], [5, 7]];
            int expected = 0;

            var actual = new _435().EraseOverlapIntervals(intervals);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test5()
        {
            int[][] intervals = [[0, 2], [1, 3], [2, 4], [3, 5], [4, 6]];
            int expected = 2;

            var actual = new _435().EraseOverlapIntervals(intervals);
            Assert.AreEqual(expected, actual);
        }

    }
}
