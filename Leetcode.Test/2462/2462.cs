namespace Leetcode.Test
{
    public class _2462
    {
        public long TotalCost(int[] costs, int k, int candidates)
        {
            if(costs.Length == 1) { return costs[0]; }

            var left = new PriorityQueue<int,int>();
            var right = new PriorityQueue<int, int>();
            var n = costs.Length-1;
            long sum = 0;
            int l = 0; int r = n;

            for (l = 0; l < candidates && l<r; l++)
            {
                left.Enqueue(costs[l], costs[l]);
                r = n - l;
                if (r <= l)
                    break;
                right.Enqueue(costs[r], costs[r]);
            }
            l--;
            for (int i = 0; i < k; i++)
            {
                var isLeft = left.TryPeek(out int currentLeft, out int ln);
                if (!isLeft) currentLeft = int.MaxValue;
                var isRight = right.TryPeek(out int currentRight, out int rn);
                if (!isRight) currentRight = int.MaxValue;

                if (isLeft && currentLeft <= currentRight)
                {
                    left.Dequeue();
                    sum += currentLeft;
                    if (r-l>1)
                    {
                        l++;
                        left.Enqueue(costs[l], costs[l]);
                    }
                }
                else
                {
                    right.Dequeue();
                    sum += currentRight;
                    if (r - l > 1)
                    {
                        r--;
                        right.Enqueue(costs[r], costs[r]);
                    }
                }
            }
            return sum;
        }

    }
}