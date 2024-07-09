namespace Leetcode.Test
{
    public class _83
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            var root = head;
            while (head.next != null)
            {
                if (head.val == head.next.val)
                    head.next = head.next.next;
                else
                    head = head.next;
            }
            return root;
        }

    }
}