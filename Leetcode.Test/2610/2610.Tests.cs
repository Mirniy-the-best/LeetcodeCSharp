using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _2610_Tests
	{

		//[Test]
		public void Test1()
		{
			var nums = new[] { 1, 3, 4, 1, 2, 3, 1 };
			var expected = new int[3][]{ [1, 3, 4, 2], [ 1, 3 ], [ 1 ] };

            var actual = new _2610().FindMatrix(nums);
			Assert.AreEqual(expected, actual);
		}

        //[Test]
        public void Test2()
        {
            var nums = new[] { 1, 2, 3, 4 };
            var expected = new int[1][] { [1, 2, 3, 4] };

            var actual = new _2610().FindMatrix(nums);
            Assert.AreEqual(expected, actual);
        }
    }
}
