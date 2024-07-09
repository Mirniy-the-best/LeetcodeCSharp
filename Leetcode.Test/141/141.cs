using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _141
    {
        public bool HasCycle(ListNode head)
        {
            if(head == null) return false;

            var l = head;
            var r = head.next;
            do
            {
                if(r == null || r.next == null || r.next.next == null)
                    return false;
                if (r == l || r.next == l || r.next.next == l)
                    return true;
                l = l.next;
                r = r.next.next;
            } while (true);
        }
    }
}