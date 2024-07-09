namespace Leetcode.Test
{
    public class _435
    {
        public int EraseOverlapIntervals(int[][] intervals)
        {
            intervals =  intervals.OrderBy(x => x[1]).ToArray();
            int cnt = 0;
            var pairEnd = intervals[0][1];

            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] < pairEnd)
                    cnt++;
                else
                    pairEnd = intervals[i][1];
            }

            return cnt;
        }

    }
}