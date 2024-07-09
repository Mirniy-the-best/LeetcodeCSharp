using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _1624_Tests
	{

		[Test]
		[TestCase("aa", 0)]
		[TestCase("abca", 2)]
		[TestCase("cbzxy", -1)]
        public void Test1(string nums, int expected)
		{
			var actual = new _1624().MaxLengthBetweenEqualCharacters(nums);
			Assert.AreEqual(expected, actual);

		}
	}
}
