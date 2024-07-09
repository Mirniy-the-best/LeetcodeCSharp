namespace Leetcode.Test
{
	[TestFixture]
	public class _100302_Tests
	{

		[Test]

		public void Test1()
		{
			int[][] points = [[2, 2], [-1, -2], [-4, 4], [-3, 1], [3, -3]];
			var s = "abdca";
			int expected = 2;

            var actual = new _100302().MaxPointsInsideSquare(points, s);
			Assert.AreEqual(expected, actual);
		}

        [Test]

        public void Test2()
        {
            int[][] points = [[1, 1], [-2, -2], [-2, 2]];
            var s = "abb";
            int expected = 1;

            var actual = new _100302().MaxPointsInsideSquare(points, s);
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void Test3()
        {
            int[][] points = [[1, 1], [-1, -1], [2, -2]];
            var s = "ccd";
            int expected = 0;

            var actual = new _100302().MaxPointsInsideSquare(points, s);
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void Test4()
        {
            int[][] points = [[16, 32], [27, 3], [23, -14], [-32, -16], [-3, 26], [-14, 33]];
            var s = "aaabfc";
            int expected = 2;

            var actual = new _100302().MaxPointsInsideSquare(points, s);
            Assert.AreEqual(expected, actual);
        }

    }
}
