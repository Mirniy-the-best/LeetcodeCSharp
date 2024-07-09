namespace Leetcode.Test
{
	[TestFixture]
	public class _1929_Tests
	{

		[Test]
		[TestCase(new[] { 1, 2, 1 }, new[] { 1, 2, 1, 1, 2, 1 })]
        [TestCase(new[] { 1, 3, 2, 1 }, new[] { 1, 3, 2, 1, 1, 3, 2, 1 })]
        public void Test1(int[] nums, int[] expected)
		{
			var actual = new _1929().GetConcatenation(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
