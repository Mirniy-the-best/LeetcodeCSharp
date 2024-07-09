using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    //public class ListNode
    //{
    //    public int val;
    //    public ListNode next;
    //    public ListNode(int val = 0, ListNode next = null)
    //    {
    //        this.val = val;
    //        this.next = next;
    //    }
    //}

    public class _19
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode p1 = head;
            ListNode p2 = head;
            for (int i = 0; i < n; i++)
                p2 = p2.next;

            while (p2 != null && p2.next != null)
            {
                p1 = p1.next;
                p2 = p2.next;
            }

            if (p2 == null)
                return p1.next;

            p1.next = p1.next.next;
            return head;
        }
    }
}