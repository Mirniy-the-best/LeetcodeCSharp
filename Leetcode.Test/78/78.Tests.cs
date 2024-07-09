namespace Leetcode.Test
{
	[TestFixture]
	public class _78_Tests
	{

		[Test]
		public void Test1()
		{
			int[] nums = [1, 2, 3];
			IList<IList<int>> expected = [[], [1], [2], [1, 2], [3], [1, 3], [2, 3], [1, 2, 3]];

            var actual = new _78().Subsets(nums);
			Assert.AreEqual(expected, actual);
		}

        [Test]
        public void Test2()
        {
            int[] nums = [0];
            IList<IList<int>> expected = [[], [0]];

            var actual = new _78().Subsets(nums);
            Assert.AreEqual(expected, actual);
        }
    }
}
