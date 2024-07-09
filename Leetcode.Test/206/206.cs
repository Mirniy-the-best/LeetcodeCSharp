namespace Leetcode.Test
{
    public class _206
    {
        ListNode result;
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null) return head;

            reverse(head).next = null;
            return result;
        }

        private ListNode reverse(ListNode head)
        {
            if (head.next == null)
            {
                result = head;
                return head;
            }

            var res = reverse(head.next);
            res.next = head;
            return head;
        }

    }
}