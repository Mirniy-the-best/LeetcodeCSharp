namespace Leetcode.Test
{
	[TestFixture]
	public class _846_Tests
	{

		[Test]
		[TestCase(new[] { 1, 2, 3, 6, 2, 3, 4, 7, 8 }, 3, true)]
		[TestCase(new[] { 1, 2, 3, 4, 5 }, 4, false)]
		public void Test1(int[] nums, int groupSize, bool expected)
		{
			var actual = new _846().IsNStraightHand(nums, groupSize);
			Assert.AreEqual(expected, actual);
		}
	}
}
