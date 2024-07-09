using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _202_Tests
	{

		[Test]
		[TestCase(19, true)]
		[TestCase(2, false)]
        [TestCase(3, false)]
        public void Test1(int nums, bool expected)
		{
			var actual = new _202().IsHappy(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
