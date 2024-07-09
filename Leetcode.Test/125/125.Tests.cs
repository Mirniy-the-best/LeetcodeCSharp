using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _125_Tests
	{

		[Test]
		[TestCase("A man, a plan, a canal: Panama", true)]
		[TestCase("race a car", false)]
        [TestCase(" ", true)]
        [TestCase("0p", false)]
        public void Test1(string nums, bool expected)
		{
			var actual = new _125().IsPalindrome(nums);
			Assert.AreEqual(expected, actual);

		}
	}
}
