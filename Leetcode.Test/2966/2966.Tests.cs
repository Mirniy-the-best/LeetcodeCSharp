namespace Leetcode.Test
{
	[TestFixture]
	public class _2966_Tests
	{

		[Test]
		public void Test1()
		{
			int[] nums = [1, 3, 4, 8, 7, 9, 3, 5, 1];
			int k = 2;
			int[][] expected = [[1, 1, 3], [3, 4, 5], [7, 8, 9]];

            var actual = new _2966().DivideArray(nums,k);
			Assert.AreEqual(expected, actual);
		}

        [Test]
        public void Test2()
        {
            int[] nums = [1, 3, 3, 2, 7, 3];
            int k = 3;
            int[][] expected = [];

            var actual = new _2966().DivideArray(nums, k);
            Assert.AreEqual(expected, actual);
        }
    }
}
