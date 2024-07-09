namespace Leetcode.Test
{
	[TestFixture]
	public class _165_Tests
	{

		[Test]
		[TestCase("1.01", "1.001", 0)]
        [TestCase("1.0", "1.0.0", 0)]
        [TestCase("0.1", "1.1", -1)]
        [TestCase("1.0", "1.0.1", -1)]
        public void Test1(string ver1, string ver2, int expected)
		{
			var actual = new _165().CompareVersion(ver1, ver2);
			Assert.AreEqual(expected, actual);
		}
	}
}
