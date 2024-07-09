//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _2_Tests
	{
        static void CustomAssert(ListNode expected, ListNode actual)
        {
            do
            {
                Assert.AreEqual(expected.val, actual.val);
                actual = actual.next;
                expected = expected.next;

            } while (actual != null);
        }

        [Test]
		public void Test1()
        {
            var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            var expected = new ListNode(7, new ListNode(0, new ListNode(8)));

            var actual = new _2().AddTwoNumbers(l1, l2);
            CustomAssert(expected, actual);
        }

        [Test]
        public void Test2()
        {
            var l1 = new ListNode(0);
            var l2 = new ListNode(0);
            var expected = new ListNode(0);

            var actual = new _2().AddTwoNumbers(l1, l2);
            CustomAssert(expected, actual);
        }

        [Test]
        public void Test3()
        {
            var l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
            var l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
            var expected = new ListNode(8, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(1))))))));

            var actual = new _2().AddTwoNumbers(l1, l2);
            CustomAssert(expected, actual);
        }
    }
}
