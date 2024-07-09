namespace Leetcode.Test
{
    public class _1701
    {
        public double AverageWaitingTime(int[][] customers)
        {
            int[] wait = new int[customers.Length];

            int time = customers[0][0];
            for (int i = 0; i < customers.Length; i++)
            {
                time = Math.Max(time, customers[i][0]) + customers[i][1];
                wait[i] = time - customers[i][0];
            }

            return wait.Average();
        }
    }
}