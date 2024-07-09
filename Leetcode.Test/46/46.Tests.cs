namespace Leetcode.Test
{
	[TestFixture]
	public class _46_Tests
	{

		//[Test]
		public void Test1()
		{
			int[] nums = [1, 2, 3];
			List<List<int>> expected = [[1, 2, 3], [1, 3, 2], [2, 1, 3], [2, 3, 1], [3, 1, 2], [3, 2, 1]];

            var actual = new _46().Permute(nums);
			Assert.AreEqual(expected, actual);
		}

        [Test]
        public void Test2()
        {
            int[] nums = [0, 1];
            List<List<int>> expected = [ [1, 0], [0, 1]];

            var actual = new _46().Permute(nums);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3()
        {
            int[] nums = [1];
            List<List<int>> expected = [[1]];

            var actual = new _46().Permute(nums);
            Assert.AreEqual(expected, actual);
        }

    }
}
