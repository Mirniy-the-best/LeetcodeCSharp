using NUnit.Framework;

namespace Leetcode.Test
{
    [TestFixture]
    public class _290_Tests
    {

        [Test]
        [TestCase("abba", "dog cat cat dog", true)]
        [TestCase("abba", "dog cat cat fish", false)]
        [TestCase("aaaa", "dog cat cat dog", false)]
        public void Test1(string pattern, string s, bool expected)
        {
            var actual = new _290().WordPattern(pattern, s);
            Assert.AreEqual(expected, actual);
        }
    }
}
