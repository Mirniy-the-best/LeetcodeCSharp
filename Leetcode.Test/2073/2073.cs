namespace Leetcode.Test
{
    public class _2073
    {
        public int TimeRequiredToBuy(int[] tickets, int k)
        {
            int s = tickets[k];
            for (int i = 0; i < k; i++)
                s += Math.Min(tickets[i], tickets[k]);

            for (int i = k + 1; i < tickets.Length; i++)
                s += Math.Min(tickets[i], tickets[k] - 1);

            return s;
        }


    }
}