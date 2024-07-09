using NUnit.Framework;

namespace Leetcode.Test
{
    [TestFixture]
    public class _128_Tests
    {

        [Test]
        [TestCase(new[] { 100, 4, 200, 1, 3, 2 }, 4)]
        [TestCase(new[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }, 9)]
        [TestCase(new[] { 0, 3, 7 }, 1)]
        [TestCase(new[] { 1, 2, 0, 1 }, 3)]
        public void Test1(int[] nums, int expected)
        {
            var actual = new _128().LongestConsecutive(nums);
            Assert.AreEqual(expected, actual);
        }
    }
}
