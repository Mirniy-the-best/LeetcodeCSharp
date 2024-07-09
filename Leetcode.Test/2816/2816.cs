using System.ComponentModel.DataAnnotations;

namespace Leetcode.Test
{
    public class _2816
    {
        public ListNode DoubleIt(ListNode head)
        {
            var res = func(head);
            if (res != 0)
                return new ListNode(res, head);

            return head;
        }

        private int func(ListNode head)
        {
            if(head == null) return 0;

            var val = head.val * 2 + func(head.next);
            head.val = val%10;
            return val/10;
        }
    }
}