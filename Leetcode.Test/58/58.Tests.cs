using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _58_Tests
	{

		[Test]
        [TestCase("Hello", 5)]
        [TestCase("Hello World", 5)]
		[TestCase("   fly me   to   the moon  ", 4)]
		public void Test1(string nums, int expected)
		{
			var actual = new _58().LengthOfLastWord(nums);
			Assert.AreEqual(expected, actual);

		}
	}
}
