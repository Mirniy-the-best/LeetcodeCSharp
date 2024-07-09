namespace Leetcode.Test
{
	[TestFixture]
	public class _100313_Tests
    {

		[Test]
		public void Test1()
		{
			var limit = 4;
			int[][] queries = [[1, 4], [2, 5], [1, 3], [3, 4]];
			int[] expected = [1, 2, 2, 3];

            var actual = new _100313().QueryResults(limit, queries);
			Assert.AreEqual(expected, actual);
		}

        [Test]
        public void Test2()
        {
            var limit = 4;
            int[][] queries = [[0, 1], [1, 2], [2, 2], [3, 4], [4, 5]];
            int[] expected = [1, 2, 2, 3, 4];

            var actual = new _100313().QueryResults(limit, queries);
            Assert.AreEqual(expected, actual);
        }

    }
}
