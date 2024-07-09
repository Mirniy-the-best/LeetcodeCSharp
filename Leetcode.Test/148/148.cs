
namespace Leetcode.Test
{
    public class _148
    {
        public ListNode SortList(ListNode head)
        {
            if (head == null || head.next == null) return head;

            var parts = Split(head);
            return Merge(SortList(parts.head), SortList(parts.tail));
        }

        private ListNode Merge(ListNode listNode1, ListNode listNode2)
        {
            if (listNode1 == null) return listNode2;
            if (listNode2 == null) return listNode1;

            ListNode res;

            if (listNode1.val <= listNode2.val)
            {
                res = listNode1;
                listNode1 = listNode1.next;
            }
            else
            {
                res = listNode2;
                listNode2 = listNode2.next;
            }
            var resHead = res;

            while (listNode2 != null && listNode1 != null)
            {
                if(listNode1.val <= listNode2.val)
                {
                    res.next = listNode1;
                    res = res.next;
                    listNode1 = listNode1.next;
                    continue;
                }

                res.next = listNode2;
                res = res.next;
                listNode2 = listNode2.next;
            }

            while(listNode1 != null)
            {
                res.next = listNode1;
                res = res.next;
                listNode1 = listNode1.next;
            }

            while (listNode2 != null)
            {
                res.next = listNode2;
                res = res.next;
                listNode2 = listNode2.next;
            }

            return resHead;
        }

        (ListNode head, ListNode tail) Split(ListNode head)
        {
            var i = head;
            var j = head.next;

            while (j != null && j.next != null)
            {
                i = i.next;
                j = j.next.next;
            }
            j = i.next;
            i.next = null;

            return new(head, j);
        }
    }
}