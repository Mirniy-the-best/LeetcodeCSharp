using NUnit.Framework;

namespace Leetcode.Test
{
    [TestFixture]
    public class _49_Tests
    {

        [Test]
        public void Test1()
        {
            var strs = new[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            var expected = new List<List<string>>
            {
                new List<string> {  "eat", "tea","ate", },
                new List<string> {  "tan", "nat" },
                new List<string> { "bat" }
            };
            var actual = new _49().GroupAnagrams(strs);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test2()
        {
            var strs = new[] { "a" };
            var expected = new List<List<string>>
            {
                new List<string> { "a" }
            };
            var actual = new _49().GroupAnagrams(strs);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3()
        {
            var strs = new[] { "" };
            var expected = new List<List<string>>
            {
                new List<string> { "" },
            };
            var actual = new _49().GroupAnagrams(strs);
            Assert.AreEqual(expected, actual);
        }

    }
}
