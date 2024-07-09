using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _21_Tests
	{
        [Test]
		public void Test1()
		{
            var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
			var expected = new ListNode(1, new ListNode(1,new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4))))));

            var actual = new _21().MergeTwoLists(list1, list2);
			while(actual!=null && expected!=null)
			{
                Assert.AreEqual(expected.val, actual.val);
                expected = expected.next;
                actual = actual.next;
            }
        }

        [Test]
        public void Test3()
        {
            var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
            var expected = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4))))));

            var actual = new _21().MergeTwoLists(list1, list2);
            while (actual != null && expected != null)
            {
                Assert.AreEqual(expected.val, actual.val);
                expected = expected.next;
                actual = actual.next;
            }
        }

        [Test]
        public void Test2()
        {
            var list1 = new ListNode();
            var list2 = new ListNode();
            var expected = new ListNode();

            var actual = new _21().MergeTwoLists(list1, list2);
            while (actual != null && expected != null)
            {
                Assert.AreEqual(expected.val, actual.val);
                expected = expected.next;
                actual = actual.next;
            }
        }

        [Test]
        public void Test31()
        {
            var list1 = new ListNode();
            var list2 = new ListNode(0);
            var expected = new ListNode(0);

            var actual = new _21().MergeTwoLists(list1, list2);
            while (actual != null && expected != null)
            {
                Assert.AreEqual(expected.val, actual.val);
                expected = expected.next;
                actual = actual.next;
            }
        }
    }
}
