namespace Leetcode.Test
{
	[TestFixture]
	public class _206_Tests
	{

		[Test]
		public void Test1()
		{
			ListNode root = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            ListNode expected = new ListNode(5, new ListNode(4, new ListNode(3, new ListNode(2, new ListNode(1)))));

			var actual = new _206().ReverseList(root);
			while(actual != null || expected != null) {
                Assert.AreEqual(expected.val, actual.val);
				expected = expected.next;
				actual = actual.next;
            }
        }

        [Test]
        public void Test2()
        {
            ListNode root = new ListNode(1, new ListNode(2));
            ListNode expected = new ListNode(2, new ListNode(1)); ;

            var actual = new _206().ReverseList(root);
            while (actual != null || expected != null)
            {
                Assert.AreEqual(expected.val, actual.val);
                expected = expected.next;
                actual = actual.next;
            }
        }

    }
}
