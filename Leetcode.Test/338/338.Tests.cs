namespace Leetcode.Test
{
	[TestFixture]
	public class _338_Tests
	{

		[Test]
		[TestCase(2, new[] { 0, 1, 1 })]
		[TestCase(5, new[] { 0, 1, 1, 2, 1, 2 })]
		public void Test1(int nums, int[] expected)
		{
			var actual = new _338().CountBits(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
