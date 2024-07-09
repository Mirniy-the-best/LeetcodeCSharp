using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _120_Tests
	{

		[Test]
		public void Test1()
		{
			IList<IList<int>> triangle = new List<IList<int>>
            {
                new List<int>() { 2 },
                new List<int>() { 3, 4 },
                new List<int>() { 6, 5, 7 },
                new List<int>() { 4, 1, 8, 3 }
            };
			int expected = 11;
            var actual = new _120().MinimumTotal(triangle);
			Assert.AreEqual(expected, actual);
		}

        [Test]
        public void Test2()
        {
            IList<IList<int>> triangle = new List<IList<int>>
            {
                new List<int>() { -10 },
            };
            int expected = -10;
            var actual = new _120().MinimumTotal(triangle);
            Assert.AreEqual(expected, actual);
        }
    }
}
