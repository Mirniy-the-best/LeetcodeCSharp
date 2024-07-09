namespace Leetcode.Test
{
	[TestFixture]
	public class _931_Tests
	{

		[Test]
		public void Test1()
		{
			int[][] matrix = [[2, 1, 3], [6, 5, 4], [7, 8, 9]];

            var actual = new _931().MinFallingPathSum(matrix);
			Assert.AreEqual(13, actual);
		}

        [Test]
        public void Test2()
        {
            int[][] matrix = [[-19, 57], [-40, -5]];

            var actual = new _931().MinFallingPathSum(matrix);
            Assert.AreEqual(-59, actual);
        }

        [Test]
        public void Test3()
        {
            int[][] matrix = [[100, -42, -46, -41], [31, 97, 10, -10], [-58, -51, 82, 89], [51, 81, 69, -51]];

            var actual = new _931().MinFallingPathSum(matrix);
            Assert.AreEqual(-36, actual);
        }

    }
}
