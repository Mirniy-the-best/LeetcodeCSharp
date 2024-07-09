namespace Leetcode.Test
{
	[TestFixture]
	public class _131_Tests
	{

		[Test]
		public void Test1()
		{
			var s = "aab";
			List<IList<string>> expected = [["a", "a", "b"], ["aa", "b"]];
            var actual = new _131().Partition(s);
			Assert.AreEqual(expected, actual);
		}

        [Test]
        public void Test2()
        {
            var s = "a";
            List<IList<string>> expected = [["a"]];
            var actual = new _131().Partition(s);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3()
        {
            var s = "aa";
            List<IList<string>> expected = [["a","a"],["aa"]];
            var actual = new _131().Partition(s);
            Assert.AreEqual(expected, actual);
        }
    }
}
