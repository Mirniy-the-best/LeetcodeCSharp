namespace Leetcode.Test
{
	[TestFixture]
	public class _100331_Tests
    {

		[Test]
		[TestCase(new[] { 1, 2, 1, 1, 3 }, 2, 4)]
		[TestCase(new[] { 1, 2, 3, 4, 5, 1 }, 0, 2)]
        [TestCase(new[] { 2 }, 1 , 1)]
        [TestCase(new[] { 28,29,29 }, 1, 3)]
        [TestCase(new[] { 28,30,30 }, 2, 3)]
        [TestCase(new[] { 2,15 }, 2, 2)]
		[TestCase(new[] { 58,60,58,59,60,60 }, 1, 4)]
        public void Test1(int[] nums, int k, int expected)
		{
			var actual = new _100331().MaximumLength(nums, k);
			Assert.AreEqual(expected, actual);
		}
	}
}
