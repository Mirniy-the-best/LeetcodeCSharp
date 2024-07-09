namespace Leetcode.Test
{
	[TestFixture]
	public class _1404_Tests
	{

		[Test]
		[TestCase("1011001", 11)]
		[TestCase("11001", 8)]
		[TestCase("11000", 6)]
		[TestCase("1101", 6)]
        [TestCase("111", 4)]
        [TestCase("10", 1)]
        [TestCase("1", 0)]
        public void Test1(string nums, int expected)
		{
			var actual = new _1404().NumSteps(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
