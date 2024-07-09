namespace Leetcode.Test
{
	[TestFixture]
	public class _867_Tests
	{

		[Test]
		public void Test1()
		{
			int[][] matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
			int[][] expected = [[1, 4, 7], [2, 5, 8], [3, 6, 9]];

            int[][] actual = new _867().Transpose(matrix);

			for (int i = 0; i < expected.Length; i++)
				for (int j = 0; j < expected[0].Length; j++)
					Assert.AreEqual(expected[i][j], actual[i][j]);

        }

		[Test]
		public void Test2()
		{
			int[][] matrix = [[1, 2, 3], [4, 5, 6]];
			int[][] expected = [[1, 4], [2, 5], [3, 6]];

            int[][] actual = new _867().Transpose(matrix);

			for (int i = 0; i < expected.Length; i++)
				for (int j = 0; j < expected[0].Length; j++)
					Assert.AreEqual(expected[i][j], actual[i][j]);

        }
	}
}
