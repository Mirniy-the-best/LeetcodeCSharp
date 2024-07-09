namespace Leetcode.Test
{
	[TestFixture]
	public class _7_Tests
	{

		[Test]
		[TestCase(123, 321)]
		[TestCase(-123, -321)]
        [TestCase(120, 21)]
        [TestCase(-2147483648, 0)]
        [TestCase(1534236469, 0)]
        public void Test1(int nums, int expected)
		{
			var actual = new _7().Reverse(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
