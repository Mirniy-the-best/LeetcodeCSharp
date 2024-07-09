using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _74_Tests
	{

		[Test]
		public void Test1()
		{
			var matrix = new int[][] { [1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60] };
			var target = 3;
			var expected = true;

            var actual = new _74().SearchMatrix(matrix, target);
			Assert.AreEqual(expected, actual);
		}

        [Test]
        public void Test2()
        {
            var matrix = new int[][] { [1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60] };
            var target = 13;
            var expected = false;

            var actual = new _74().SearchMatrix(matrix, target);
            Assert.AreEqual(expected, actual);
        }
    }
}
