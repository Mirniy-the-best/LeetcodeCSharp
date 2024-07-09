using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _1897_Tests
	{

		[Test]
		[TestCase(new[] { "abc", "aabc", "bc" }, true)]
		[TestCase(new[] { "ab", "a" }, false)]
		[TestCase(new[] { "abbab" }, true)]
		public void Test1(string[] nums, bool expected)
		{
			var actual = new _1897().MakeEqual(nums);
			Assert.AreEqual(expected, actual);

		}
	}
}
