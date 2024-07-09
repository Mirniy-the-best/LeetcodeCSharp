namespace Leetcode.Test
{
	[TestFixture]
	public class _1291_Tests
	{

		[Test]
		[TestCase(100, 300, new[]{123, 234})]
        [TestCase(1000, 13000, new[] { 1234, 2345, 3456, 4567, 5678, 6789, 12345 })]
		[TestCase(234, 2314, new[] { 234, 345, 456, 567, 678, 789, 1234 })]
        public void Test1(int min, int max, int[] expected)
		{
			var actual = new _1291().SequentialDigits(min, max);
			Assert.AreEqual(expected, actual);
		}
	}
}
