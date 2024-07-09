namespace Leetcode.Test
{
	[TestFixture]
	public class _100303_Tests
    {

		[Test]
		[TestCase(new[] { 1, 3, 1, 7 }, new[] { 1, 3, 2, 4 }, 1, new[] { 0, -1, 2, -1 })]
		[TestCase(new[] { 1, 2, 3 }, new[] { 10 }, 5, new[] { -1 })]
        public void Test1(int[] nums, int[] q, int x, int[] expected)
		{
			var actual = new _100303().OccurrencesOfElement(nums, q,x);
			Assert.AreEqual(expected, actual);
		}
	}
}
