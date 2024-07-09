namespace Leetcode.Test
{
	[TestFixture]
	public class _557_Tests
	{

		[Test]
		[TestCase("Let's take LeetCode contest", "s'teL ekat edoCteeL tsetnoc")]
		[TestCase("Mr Ding", "rM gniD")]
		public void Test1(string nums, string expected)
		{
			var actual = new _557().ReverseWords(nums);
			Assert.AreEqual(expected, actual);
		}
	}
}
