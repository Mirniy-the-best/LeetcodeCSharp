using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _141_Tests
	{
        [Test]
        public void Test1()
        {
            var node1 = new ListNode(3, null);
            var node2 = new ListNode(2, null);
            var node3 = new ListNode(0, null);
            var node4 = new ListNode(-4, null);
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node2;

            var expected = true;

            var actual = new _141().HasCycle(node1);
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Test2()
        {
            var node1 = new ListNode(1, null);
            var node2 = new ListNode(2, null);
            node1.next = node2;
            node2.next = node1;

            var expected = true;

            var actual = new _141().HasCycle(node1);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_2()
        {
            var node1 = new ListNode(1, null);
            var node2 = new ListNode(2, null);
            node1.next = node2;

            var expected = false;

            var actual = new _141().HasCycle(node1);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3()
        {
            var node1 = new ListNode(1, null);

            var expected = false;

            var actual = new _141().HasCycle(node1);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test4()
        {
            var node1 = new ListNode(3, null);
            var node2 = new ListNode(2, null);
            var node3 = new ListNode(0, null);
            var node4 = new ListNode(-4, null);
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;

            var expected = false;

            var actual = new _141().HasCycle(node1);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test5()
        {
            var expected = false;

            var actual = new _141().HasCycle(null);
            Assert.AreEqual(expected, actual);
        }
    }
}
