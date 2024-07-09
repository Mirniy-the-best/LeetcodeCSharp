namespace Leetcode.Test
{
	[TestFixture]
	public class _217_Tests
	{

		[Test]
		[TestCase(new[] { 1, 2, 3, 1 }, true)]
		[TestCase(new[] { 1, 2, 3, 4 }, false)]
		[TestCase(new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
		public void Test1(int[] nums, bool expected)
		{
			var actual = new _217().ContainsDuplicate(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
