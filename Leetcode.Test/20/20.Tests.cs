using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _20_Tests
	{

		[Test]
		[TestCase("()", true)]
		[TestCase("()[]{}", true)]
		[TestCase("\"(]\"", false)]
		public void Test1(string nums, bool expected)
		{
			var actual = new _20().IsValid(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
