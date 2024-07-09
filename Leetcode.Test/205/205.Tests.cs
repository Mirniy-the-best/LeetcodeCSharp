using NUnit.Framework;

namespace Leetcode.Test
{
    [TestFixture]
    public class _205_Tests
    {

        [Test]
        [TestCase("egg", "add", true)]
        [TestCase("foo", "bar", false)]
        [TestCase("paper", "title", true)]
        [TestCase("badc", "baba", false)]
        public void Test1(string s1, string s2, bool expected)
        {
            var actual = new _205().IsIsomorphic(s1, s2);
            Assert.AreEqual(expected, actual);
        }
    }
}
