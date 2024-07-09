namespace Leetcode.Test
{
	[TestFixture]
	public class _443_Tests
	{

		[Test]
		[TestCase(new[] { 'a', 'a', 'a', 'a', 'a', 'a', 'b' }, 3)]
		[TestCase(new[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' }, 6)]
		[TestCase(new[] { 'a' }, 1)]
        [TestCase(new[] { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' }, 4)]
        public void Test1(char[] nums, int expected)
		{
			var actual = new _443().Compress(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
