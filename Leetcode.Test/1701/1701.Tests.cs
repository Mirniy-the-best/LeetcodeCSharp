namespace Leetcode.Test
{
	[TestFixture]
	public class _1701_Tests
	{

		[Test]
		public void Test1()
		{
			double expected = 5.000;
			int[][] customers = [[1, 2], [2, 5], [4, 3]];

            var actual = new _1701().AverageWaitingTime(customers);
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Test2()
		{
			double expected = 3.25000;
			int[][] customers = [[5, 2], [5, 4], [10, 3], [20, 1]];

            var actual = new _1701().AverageWaitingTime(customers);
			Assert.AreEqual(expected, actual);
		}


	}
}
