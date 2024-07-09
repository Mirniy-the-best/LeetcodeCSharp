namespace Leetcode.Test
{
	[TestFixture]
	public class _344_Tests
	{

		[Test]
		[TestCase(new[] { 'h', 'e', 'l', 'l', 'o' }, new[] { 'o', 'l', 'l', 'e', 'h' })]
		[TestCase(new[] { 'H', 'a', 'n', 'n', 'a', 'h' }, new[] { 'h', 'a', 'n', 'n', 'a', 'H' })]
		public void Test1(char[] nums, char[] expected)
		{
			new _344().ReverseString(nums);
			Assert.AreEqual(expected, nums);
		}
	}
}
