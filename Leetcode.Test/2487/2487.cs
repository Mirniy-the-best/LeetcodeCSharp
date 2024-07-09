namespace Leetcode.Test
{
    public class _2487
    {
        public ListNode RemoveNodes(ListNode head)
        {
            if (head.next == null) return head;

            ListNode node = RemoveNodes(head.next);
            head.next = node;
            if (node.val > head.val)
                return node;
            return head;
        }
    }
}