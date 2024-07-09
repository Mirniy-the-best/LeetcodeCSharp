namespace Leetcode.Test
{
	[TestFixture]
	public class _1823_Tests
	{

		[Test]
		[TestCase(5, 2, 3)]
		[TestCase(6, 5, 1)]
		public void Test1(int n, int k, int expected)
		{
			var actual = new _1823().FindTheWinner(n, k);
			Assert.AreEqual(expected, actual);
		}
	}
}
