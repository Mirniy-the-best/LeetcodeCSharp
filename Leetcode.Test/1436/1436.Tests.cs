//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _1436_Tests
	{

        [Test]
        public void Test1()
        {
            List<IList<string>> nums = [["London", "New York"], ["New York", "Lima"], ["Lima", "Sao Paulo"]];
            var expected = "Sao Paulo";
            var actual = new _1436().DestCity(nums);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test2()
        {
            List<IList<string>> nums = [["B", "C"], ["D", "B"], ["C", "A"]];
            var expected = "A";
            var actual = new _1436().DestCity(nums);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3()
        {
            List<IList<string>> nums = [["A", "Z"]];
            var expected = "Z";
            var actual = new _1436().DestCity(nums);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test4()
        {
            List<IList<string>> nums = [["A", "Z"], ["Z", "B"], ["C", "E"]];
            var expected = "B";
            var actual = new _1436().DestCity(nums);
            Assert.AreEqual(expected, actual);
        }

    }
}
