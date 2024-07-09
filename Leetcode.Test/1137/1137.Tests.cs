namespace Leetcode.Test
{
	[TestFixture]
	public class _1137_Tests
	{

		[Test]
        [TestCase(0, 0)]
        [TestCase(4, 4)]
		[TestCase(25, 1389537)]
		public void Test1(int num, int expected)
		{
			var actual = new _1137().Tribonacci(num);
			Assert.AreEqual(expected, actual);
		}
	}
}
