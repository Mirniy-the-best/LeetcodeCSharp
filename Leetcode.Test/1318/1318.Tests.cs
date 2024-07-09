namespace Leetcode.Test
{
	[TestFixture]
	public class _1318_Tests
	{

		[Test]
		[TestCase(2,6,5,3)]
		[TestCase(4,2,7,1)]
		[TestCase(1,2,3,0)]
        [TestCase(8, 3, 5, 3)]
        public void Test1(int a, int b, int c, int expected)
		{
			var actual = new _1318().MinFlips(a,b,c);
			Assert.AreEqual(expected, actual);
		}
	}
}
