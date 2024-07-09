using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _455_Tests
	{

		[Test]
		[TestCase(new[] { 1, 2, 3 }, new[] { 1, 1 }, 1)]
        [TestCase(new[] { 1, 2}, new[] { 1, 2, 3 }, 2)]
        [TestCase(new[] { 1, 2, 3 }, new[] { 2, 4 }, 2)]
        [TestCase(new[] { 2, 3 }, new[] { 1, 2 }, 1)]
        [TestCase(new[] { 2, 3 }, new int[0], 0)]
        public void Test1(int[] g,int[]s, int expected)
		{
			var actual = new _455().FindContentChildren(g,s);
			Assert.AreEqual(expected, actual);

		}
	}
}
