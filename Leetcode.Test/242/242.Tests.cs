//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _242_Tests
	{

		[Test]
		[TestCase("anagram", "nagaram", true)]
		[TestCase("rat", "car", false)]
		public void Test1(string s1, string s2, bool expected)
		{
			var actual = new _242().IsAnagram(s1,s2);
			Assert.AreEqual(expected, actual);

		}
	}
}
