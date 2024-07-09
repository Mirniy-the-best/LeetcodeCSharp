namespace Leetcode.Test
{
    public class _2058
    {
        public int[] NodesBetweenCriticalPoints(ListNode head)
        {
            if (head == null || head.next == null || head.next.next == null)
                return [-1, -1];

            var prev = head;
            var cur = head.next;
            var next = head.next.next;
            int i = 1;
            int firstExtr = 0;
            int ifirstExtr = -1;
            int latestExtr = 0;
            int ilatectExtr = -1;
            int latestDiff = int.MaxValue;

            while (next != null)
            {
                if ((cur.val < next.val && cur.val < prev.val)
                    || (cur.val > next.val && cur.val > prev.val))
                {
                    if(ifirstExtr < 0)
                    {
                        ifirstExtr = i;
                        firstExtr = cur.val;
                    }
                    else
                    {
                        latestDiff = Math.Min(latestDiff, i - (ilatectExtr > 0 ? ilatectExtr : ifirstExtr));
                        latestExtr = cur.val;
                        ilatectExtr = i;
                    }
                }

                i++;
                prev=prev.next;
                cur = cur.next;
                next = next.next;
            }

            return [ilatectExtr > 0 ? latestDiff : -1,
                ilatectExtr > 0 ? ilatectExtr - ifirstExtr : -1];
        }


    }
}