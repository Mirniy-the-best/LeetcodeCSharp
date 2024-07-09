using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _1235_Tests
	{

		[Test]
		[TestCase(new[] { 1, 2, 3, 3 }, new[] { 3, 4, 5, 6 }, new[] { 50, 10, 40, 70 }, 120)]
        [TestCase(new[] { 1, 2, 3, 4, 6 }, new[] { 3, 5, 10, 6, 9 }, new[] { 20, 20, 100, 70, 60 }, 150)]
        [TestCase(new[] { 1, 1, 1 }, new[] { 2, 3, 4 }, new[] { 5, 6, 4 }, 6)]
		[TestCase(new[] { 4, 2, 4, 8, 2 }, new[] { 5, 5, 5, 10, 8 }, new[] { 1, 2, 8, 10, 4 }, 18)]
        public void Test1(int[] startTime, int[] endTime, int[] profit , int expected)
		{
			var actual = new _1235().JobScheduling(startTime, endTime, profit);
			Assert.AreEqual(expected, actual);
		}
	}
}
