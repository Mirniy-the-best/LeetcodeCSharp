namespace Leetcode.Test
{
	[TestFixture]
	public class _649_Tests
	{

		[Test]
		[TestCase("RD", "Radiant")]
        [TestCase("RDD", "Dire")]
        [TestCase("RDDR", "Radiant")]
        [TestCase("DDRRR", "Dire")]
        public void Test1(string nums, string expected)
		{
			var actual = new _649().PredictPartyVictory(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
