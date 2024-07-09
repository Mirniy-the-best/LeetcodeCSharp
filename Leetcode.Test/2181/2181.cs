namespace Leetcode.Test
{
    public class _2181
    {
        public ListNode MergeNodes(ListNode head)
        {
            ListNode summNode = head;
            ListNode current = head.next.next;

            while (current != null)
            {
                if(current.val != 0)
                {
                    summNode.next.val += current.val;
                }
                else
                {
                    summNode = summNode.next;
                    summNode.next.val = 0;
                }
                current = current.next;
            }
            if (summNode.next.val == 0)
                summNode.next = null;

            return head.next;
        }


    }
}