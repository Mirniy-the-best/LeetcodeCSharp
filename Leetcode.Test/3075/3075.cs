namespace Leetcode.Test
{
    public class _3075
    {
        public long MaximumHappinessSum(int[] happiness, int k)
        {
            Array.Sort(happiness, (a,b) =>b.CompareTo(a));

            long res = 0;
            for (int i = 0; i < k; i++)
                res += Math.Max(happiness[i] - i, 0);

            return res;
        }

    }
}