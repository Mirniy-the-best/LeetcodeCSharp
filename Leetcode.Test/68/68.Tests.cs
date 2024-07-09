using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _68_Tests
	{
        private void CompareLists(IList<string> list1, IList<string> list2)
        {
            Assert.AreEqual(list1.Count, list2.Count);
            for (int i = 0; i < list1.Count; i++)
            {
                Assert.AreEqual(list1[i], list2[i]);
            }
        }


		[Test]
		public void Test1()
		{
			var words = new[] { "This", "is", "an", "example", "of", "text", "justification." };
			var maxWidth = 16;
			var expected = new List<string> {
   "This    is    an",
   "example  of text",
   "justification.  "};

            var actual = new _68().FullJustify(words, maxWidth);
            CompareLists(expected, actual);
		}

        [Test]
        public void Test2()
        {
            var words = new[] { "What", "must", "be", "acknowledgment", "shall", "be" };
            var maxWidth = 16;
            var expected = new List<string> {
   "What   must   be",
  "acknowledgment  ",
  "shall be        "};

            var actual = new _68().FullJustify(words, maxWidth);
            CompareLists(expected, actual);
        }

        [Test]
        public void Test3()
        {
            var words = new[] { "Science", "is", "what", "we", "understand", "well", "enough", "to", "explain", "to", "a", "computer.", "Art", "is", "everything", "else", "we", "do" };
            var maxWidth = 20;
            var expected = new List<string> {
  "Science  is  what we",
  "understand      well",
  "enough to explain to",
  "a  computer.  Art is",
  "everything  else  we",
  "do                  "};

            var actual = new _68().FullJustify(words, maxWidth);
            CompareLists(expected, actual);
        }

        [Test]
        public void Test4()
        {
            var words = new[] { "Here", "is", "an", "example", "of", "text", "justification." };
            var maxWidth = 15;
            var expected = new List<string> {
                "Here    is   an",
                "example of text",
                "justification. "};

            var actual = new _68().FullJustify(words, maxWidth);
            CompareLists(expected, actual);
        }
    }
}
