using static Leetcode.Test._933;

namespace Leetcode.Test
{
	[TestFixture]
	public class _933_Tests
	{

		[Test]
		public void Test1()
		{
			var recentCounter = new _933.RecentCounter();
            var n1 = recentCounter.Ping(1);     // requests = [1], range is [-2999,1], return 1
			Assert.AreEqual(1, n1);
            var n2 = recentCounter.Ping(100);   // requests = [1, 100], range is [-2900,100], return 2
			Assert.AreEqual(2, n2);
            var n3 = recentCounter.Ping(3001);  // requests = [1, 100, 3001], range is [1,3001], return 3
			Assert.AreEqual(3, n3 );
            var n4 = recentCounter.Ping(3002);  // requests = [1, 100, 3001, 3002], range is [2,3002], return 3
            Assert.AreEqual(3, n4);
		}
	}
}
