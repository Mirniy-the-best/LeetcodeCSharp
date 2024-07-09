namespace Leetcode.Test
{
	[TestFixture]
	public class _216_Tests
	{

		[Test]
		public void Test1()
		{
			int k = 3;
			int n = 7;
            IList<IList<int>> expected = [new List<int>([1, 2, 4])];

            var actual = new _216().CombinationSum3(k,n);
			Assert.AreEqual(expected, actual);
		}

        [Test]
        public void Test2()
        {
            int k = 3;
            int n = 9;
            IList<IList<int>> expected = [
                new List<int>([1, 2, 6]),
                new List<int>([1,3,5]),
                new List<int>([2,3,4])
            ];

            var actual = new _216().CombinationSum3(k, n);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3()
        {
            int k = 4;
            int n = 1;
            IList<IList<int>> expected = [];

            var actual = new _216().CombinationSum3(k, n);
            Assert.AreEqual(expected, actual);
        }


    }
}
