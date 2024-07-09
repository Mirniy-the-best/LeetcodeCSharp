using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _1155_Tests
	{

		[Test]
		[TestCase(1,6,3,1)]
		[TestCase(2, 6, 7, 6)]
        [TestCase(2, 6, 8, 5)]
        [TestCase(1, 2, 3, 0)]
        [TestCase(30, 30, 500, 222616187)]
        public void Test1(int n, int k, int target, int expected)
		{
			var actual = new _1155().NumRollsToTarget(n, k, target);
			Assert.AreEqual(expected, actual);

		}
	}
}
