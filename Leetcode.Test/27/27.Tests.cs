using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _27_Tests
	{

		[Test]
		[TestCase(new[] { 3, 2, 2, 3 }, 3, 2)]
		[TestCase(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5)]
        [TestCase(new[] {1}, 1, 0)]
        public void Test1(int[] nums, int k, int expected)
		{
			var actual = new _27().RemoveElement(nums, k);
			Assert.AreEqual(expected, actual);

		}

        [Test]
        public void Test2()
        {
            var actual = new _27().RemoveElement(Array.Empty<int>(), 0);
            Assert.AreEqual(0, actual);

        }

    }
}
