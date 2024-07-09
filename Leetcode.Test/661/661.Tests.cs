using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _661_Tests
	{

		[Test]
		public void Test1()
		{
			int[][] input = [[1, 1, 1], [1, 0, 1], [1, 1, 1]];
			int[][] expected = [[0, 0, 0], [0, 0, 0], [0, 0, 0]];
            var actual = new _661().ImageSmoother(input);
			Assert.AreEqual(expected, actual);
		}
        [Test]
        public void Test2()
        {
            int[][] input = [[100, 200, 100], [200, 50, 200], [100, 200, 100]];
            int[][] expected = [[137, 141, 137], [141, 138, 141], [137, 141, 137]];
            var actual = new _661().ImageSmoother(input);
            Assert.AreEqual(expected, actual);
        }

    }
}
