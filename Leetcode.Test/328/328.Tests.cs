namespace Leetcode.Test
{
	[TestFixture]
	public class _328_Tests
	{

		[Test]
		public void Test1()
		{
			var nums = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            var expected = new ListNode(1, new ListNode(3, new ListNode(5, new ListNode(2, new ListNode(4)))));
            var actual = new _328().OddEvenList(nums);
			while (actual != null || expected != null) {
                Assert.AreEqual(expected.val, actual.val);
				actual = actual.next;
				expected = expected.next;
            }
        }


        [Test]
        public void Test2()
        {
            var nums = new ListNode(2, new ListNode(1, new ListNode(3, new ListNode(5, new ListNode(6, new ListNode(4, new ListNode(7)))))));
            var expected = new ListNode(2, new ListNode(3, new ListNode(6, new ListNode(7, new ListNode(1, new ListNode(5, new ListNode(4)))))));
            var actual = new _328().OddEvenList(nums);
            while (actual != null || expected != null)
            {
                Assert.AreEqual(expected.val, actual.val);
                actual = actual.next;
                expected = expected.next;
            }
        }
    }
}
