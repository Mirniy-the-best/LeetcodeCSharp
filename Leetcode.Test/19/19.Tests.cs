using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _19_Tests
	{

        static void CustomAssert(ListNode expected, ListNode actual)
        {


            do
            {
                if (actual == null || expected == null)
                {
                    Assert.AreEqual(expected, actual);
                    return;
                }

                Assert.AreEqual(expected.val, actual.val);
                actual = actual.next;
                expected = expected.next;
            } while (actual != null || expected!=null);
        }

        [Test]
        public void Test1()
        {
            var l1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            int n = 2;
            var expected = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(5))));

            var actual = new _19().RemoveNthFromEnd(l1, n);
            CustomAssert(expected, actual);
        }

        [Test]
        public void Test2()
        {
            var l1 = new ListNode(1);
            int n = 1;
            ListNode expected = null;

            var actual = new _19().RemoveNthFromEnd(l1, n);
            CustomAssert(expected, actual);
        }

        [Test]
        public void Test3()
        {
            var l1 = new ListNode(1, new ListNode(2));
            int n = 1;
            var expected = new ListNode(1);

            var actual = new _19().RemoveNthFromEnd(l1, n);
            CustomAssert(expected, actual);
        }

        [Test]
        public void Test4()
        {
            var l1 = new ListNode(1, new ListNode(2));
            int n = 2;
            var expected = new ListNode(2);

            var actual = new _19().RemoveNthFromEnd(l1, n);
            CustomAssert(expected, actual);
        }
    }
}
