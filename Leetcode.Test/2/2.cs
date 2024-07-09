using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class _2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode res = null;
            ListNode last = null;
            var extra = 0;

            do
            {
                var val1 = l1!=null ? l1.val : 0;
                var val2 = l2 != null ? l2.val : 0;

                var summ = val1 + val2 + extra;
                if (summ > 9)
                {
                    extra = 1;
                    summ %= 10;
                }
                else
                {
                    extra = 0;
                }
                var r = new ListNode(summ);
                if (last != null)
                    last.next = r;
                else
                    res = r;
                last = r;

                l1 = l1?.next;
                l2 = l2?.next;

            } while (l1 != null || l2 != null);
            if(extra>0) { last.next = new ListNode(extra); }

            return res;
        }
    }
}