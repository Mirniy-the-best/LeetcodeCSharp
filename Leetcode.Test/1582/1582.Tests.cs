//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using NUnit.Framework;
using System.Collections;

namespace Leetcode.Test
{
	[TestFixture]
	public class _1582_Tests
	{
        private class MyDataClass
        {
            public static IEnumerable TestCases
            {
                get
                {
                    int[][] a1 = [[1, 0, 0], [0, 0, 1], [1, 0, 0]];

                    yield return new TestCaseData(a1).Returns(1);
                    //yield return new TestCaseData(new int[][] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } }).Returns(3);
                }
            }
        }

		[Test]
        public void Test1()
		{
            int[][] nums = [[1, 0, 0], [0, 0, 1], [1, 0, 0]];
            var actual = new _1582().NumSpecial(nums);
            Assert.AreEqual(actual, 1);
		}

        [Test]
        public void Test2()
        {
            int[][] nums = [[1, 0, 0], [0, 1, 0], [0, 0, 1]];
            var actual = new _1582().NumSpecial(nums);
            Assert.AreEqual(actual, 3);
        }
        [Test]
        public void Test3()
        {
            int[][] nums = [[0, 0, 0, 0, 0, 1, 0, 0], [0, 0, 0, 0, 1, 0, 0, 1], [0, 0, 0, 0, 1, 0, 0, 0], [1, 0, 0, 0, 1, 0, 0, 0], [0, 0, 1, 1, 0, 0, 0, 0]];
            var actual = new _1582().NumSpecial(nums);
            Assert.AreEqual(1, actual);
        }

        [Test]
        public void Test4()
        {
            int[][] nums = [[0, 0, 0, 0, 0, 0, 0, 0, 0, 0], [0, 1, 0, 0, 0, 0, 1, 0, 0, 0], [1, 0, 0, 1, 0, 0, 0, 1, 0, 0], [0, 0, 0, 0, 0, 1, 0, 0, 0, 1]];
            var actual = new _1582().NumSpecial(nums);
            Assert.AreEqual(0, actual);
        }

    }
}
