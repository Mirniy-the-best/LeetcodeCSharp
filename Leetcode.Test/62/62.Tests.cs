namespace Leetcode.Test
{
	[TestFixture]
	public class _62_Tests
	{

		[Test]
		[TestCase(3, 7, 28)]
		[TestCase(3, 2, 3)]
		public void Test1(int m, int n, int expected)
		{
			var actual = new _62().UniquePaths(m,n);
			Assert.AreEqual(expected, actual);
		}
	}
}
