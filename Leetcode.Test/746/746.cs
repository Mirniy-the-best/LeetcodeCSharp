namespace Leetcode.Test
{
    public class _746
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            var stairs = new int[cost.Length];
            stairs[0] = cost[0];
            stairs[1] = cost[1];

            for (int i = 2; i < cost.Length; i++)
                stairs[i] = Math.Min(stairs[i - 1], stairs[i - 2]) + cost[i];

            return Math.Min(stairs[cost.Length - 1], stairs[cost.Length - 2]);
        }

    }
}