namespace Leetcode.Test
{
    public class _328
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null || head.next == null) return head;

            var odd = head;
            var even = head.next;

            while(even != null && even.next != null)
            {
                var temp = even.next;
                even.next = temp.next;
                even = even.next;

                temp.next = odd.next;
                odd.next = temp;
                odd = temp;
            }

            return head;
        }

    }
}