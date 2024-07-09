using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _23
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            ListNode result = null;
            ListNode last = null;

            for(int? mini = Min(lists); mini != null; mini = Min(lists))
            {
                if (result == null)
                {
                    result = lists[mini.Value];
                    last = result;
                }
                else
                {
                    last.next = lists[mini.Value];
                    last = last.next;
                }
                lists[mini.Value] = lists[mini.Value].next;
            }
            return result;
        }

        private int? Min(ListNode[] nodes)
        {
            int? min = null;
            int? mini = null;
            for(int i = 0; i < nodes.Length; i++)
            {
                if (nodes[i] != null)
                    if(!min.HasValue || nodes[i].val < min.Value)
                    {
                        min = nodes[i].val;
                        mini = i;
                    }
            }
            return mini;
        }
    }
}