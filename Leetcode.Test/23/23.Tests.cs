using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _23_Tests
	{

		private void CompareNodes( ListNode expected, ListNode actual )
		{
			while ( expected != null || actual !=null ) {
                Assert.AreEqual( expected?.val, actual?.val );
                expected = expected.next;
                actual = actual.next;
            }
        }

		[Test]
		public void Test1()
		{
			var l1 = new ListNode(1, new ListNode(4, new ListNode(5)));
            var l2 = new ListNode(1, new ListNode(3, new ListNode(4)));
            var l3 = new ListNode(2, new ListNode(6));

            var expected = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4, new ListNode(5, new ListNode(6))))))));
            var actual = new _23().MergeKLists(new[] {l1,l2,l3});
            CompareNodes(expected, actual);
		}


        [Test]
        public void Test2()
        {
            ListNode expected = null;
            var actual = new _23().MergeKLists(new ListNode[] { });
            CompareNodes(expected, actual);
        }
    }
}
