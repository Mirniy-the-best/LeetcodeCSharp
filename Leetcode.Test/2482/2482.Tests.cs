//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _2482_Tests
	{

        [Test]
        public void Test1()
        {
            int[][] nums = [[0, 1, 1], [1, 0, 1], [0, 0, 1]];
            int[][] expected = [[0, 0, 4], [0, 0, 4], [-2, -2, 2]];
            var actual = new _2482().OnesMinusZeros(nums);

            for (int i = 0; i < nums.Length; i++)
                for (int j = 0; j < nums[i].Length; j++)
                    Assert.AreEqual(expected[i][j], actual[i][j]);
        }

        [Test]
        public void Test2()
        {
            int[][] nums = [[1, 1, 1], [1, 1, 1]];
            int[][] expected = [[5, 5, 5], [5, 5, 5]];
            var actual = new _2482().OnesMinusZeros(nums);

            for (int i = 0; i < nums.Length; i++)
                for (int j = 0; j < nums[i].Length; j++)
                    Assert.AreEqual(expected[i][j], actual[i][j]);
        }

    }
}
