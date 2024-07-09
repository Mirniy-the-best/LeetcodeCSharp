namespace Leetcode.Test
{
	[TestFixture]
	public class _1704_Tests
	{

		[Test]
		[TestCase("book", true)]
        [TestCase("textbook", false)]
		public void Test1(string nums, bool expected)
		{
			var actual = new _1704().HalvesAreAlike(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
