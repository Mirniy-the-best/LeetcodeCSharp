namespace Leetcode.Test
{
    public class _2130
    {
        public int PairSum(ListNode head)
        {
            var l = head;
            var r = head;

            while(r!= null && r.next != null)
            {
                l = l.next;
                r = r.next.next;
            }

            var right = reverse(l);

            int max = -1;
            while(right!=null)
            {
                if (head.val + right.val > max)
                    max = head.val + right.val;

                head = head.next;
                right = right.next;
            }

            return max;
        }

        ListNode reverse(ListNode head)
        {
            ListNode prev = null;
            ListNode cur = head;
            ListNode nxt;

            while(cur != null)
            {
                nxt = cur.next;
                cur.next = prev;
                prev = cur;
                cur = nxt;
            }
            return prev;
        }

    }
}