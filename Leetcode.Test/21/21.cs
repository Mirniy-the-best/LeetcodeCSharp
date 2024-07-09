using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _21
    {
        public ListNode MergeTwoLists1(ListNode list1, ListNode list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;

            if(list1.val <= list2.val)
            {
                list1.next = MergeTwoLists(list1.next, list2);
                return list1;
            }
            else
            {
                list2.next = MergeTwoLists(list1, list2.next);
                return list2;
            }

        }

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
                ListNode result = null;
                ListNode last = null;

                while (list1 != null || list2 != null)
                {
                    if (result != null)
                    {
                        last.next = PopMin(ref list1, ref list2);
                        last = last.next;
                        continue;
                    }
                    result = PopMin(ref list1, ref list2);
                    last = result;
                }
                return result;
        }

        ListNode PopMin(ref ListNode list1, ref ListNode list2)
        {
            ListNode result;
            if (list1 == null) {
                result = list2;
                list2 = list2.next;
                return result;
            }
            if (list2 == null) 
            { 
                result =list1;
                list1 = list1.next;
                return result;
            }
            if (list1.val <= list2.val)
            {
                result = list1;
                list1 = list1.next;
            }
            else
            {
                result = list2;
                list2 = list2.next;
            }
            return result;
        }

    }
}