namespace Leetcode.Test
{
	[TestFixture]
	public class _2582_Tests
	{

		[Test]
		[TestCase(2, 341, 2)]
		[TestCase(18, 38, 5)]
		[TestCase(4,5,2)]
        [TestCase(3, 2, 3)]
        public void Test1(int n, int time, int expected)
		{
			var actual = new _2582().PassThePillow(n, time);
			Assert.AreEqual(expected, actual);
		}
	}
}
