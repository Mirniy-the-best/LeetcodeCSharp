using System.Text.RegularExpressions;

namespace Leetcode.Test
{
	[TestFixture]
	public class _2225_Tests
    {
        [Test]
		public void Test1()
		{
			var matches = new int[][] { [1, 3], [2, 3], [3, 6], [5, 6], [5, 7], [4, 5], [4, 8], [4, 9], [10, 4], [10, 9]};
			List<List<int>> expected = new List<List<int>>
			{
				new List<int> {1, 2, 10 },
				new List<int>{4, 5, 7, 8 }

			};
            var actual = new _2225().FindWinners(matches);
			for (int i = 0; i < expected.Count; i++)
				Assert.AreEqual(true, Enumerable.SequenceEqual(expected[i].Order(), actual[i].Order()));
		}

        [Test]
		public void Test2()
		{
			var matches = new int[][] { [2, 3], [1, 3], [5, 4], [6, 4] };
			List<List<int>> expected = new List<List<int>>
			{
				new List<int> {1,2,5,6 },
				new List<int>{}

			};
            var actual = new _2225().FindWinners(matches);
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(true, Enumerable.SequenceEqual(expected[i].Order(), actual[i].Order()));
        }

	}
}
