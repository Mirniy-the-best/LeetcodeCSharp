namespace Leetcode.Test
{
	[TestFixture]
	public class __100314_Tests
    {

		[Test]
		public void Test1()
		{
			int[][] nums = [[1, 2], [2, 3, 3], [2, 3, 1], [2, 2, 2]];
			bool[] expected = [false, true, true];

            var actual = new _100314().GetResults(nums);
			Assert.AreEqual(expected, actual);
		}

        [Test]
        public void Test2()
        {
            int[][] nums = [[1, 7], [2, 7, 6], [1, 2], [2, 7, 5], [2, 7, 6]];
            bool[] expected = [true, true, false];

            var actual = new _100314().GetResults(nums);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3()
        {
            int[][] nums = [[1, 22], [1, 10], [1, 17], [1, 2], [2, 26, 6], [1, 27], [2, 29, 13], [1, 21], [2, 2, 16], [2, 21, 28]];
            bool[] expected = [true, false, false, false];

            var actual = new _100314().GetResults(nums);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test4()
        {
            int[][] nums = [[1, 10], [2, 8, 6], [1, 6], [1, 1], [2, 14, 6]];
            bool[] expected = [true, false];

            var actual = new _100314().GetResults(nums);
            Assert.AreEqual(expected, actual);
        }



    }
}
