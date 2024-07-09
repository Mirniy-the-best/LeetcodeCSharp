namespace Leetcode.Test
{
	[TestFixture]
	public class _1608_Tests
	{

		[Test]
		[TestCase(new[] { 3, 5 }, 2)]
		[TestCase(new[] { 0, 4, 3, 0, 4 }, 3)]
        [TestCase(new[] { 0, 0 }, -1)]
        public void Test1(int[] nums, int expected)
		{
			var actual = new _1608().SpecialArray(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
