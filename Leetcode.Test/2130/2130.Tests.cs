namespace Leetcode.Test
{
	[TestFixture]
	public class _2130_Tests
	{

		[Test]
		public void Test1()
		{
			ListNode head = new ListNode(5, new ListNode(4, new ListNode(2, new ListNode(1))));
			var expected = 6;
			var actual = new _2130().PairSum(head);
			Assert.AreEqual(expected, actual);
		}

        [Test]
        public void Test2()
        {
            ListNode head = new ListNode(4, new ListNode(2, new ListNode(2, new ListNode(3))));
            var expected = 7;
            var actual = new _2130().PairSum(head);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3()
        {
            ListNode head = new ListNode(1, new ListNode(100000));
            var expected = 100001;
            var actual = new _2130().PairSum(head);
            Assert.AreEqual(expected, actual);
        }
    }
}
