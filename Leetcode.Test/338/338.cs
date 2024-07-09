namespace Leetcode.Test
{
    public class _338
    {
        public int[] CountBits(int n)
        {
            var result = new int[n+1];
            for (int i = 1; i <= n; i++)
                result[i] = int.PopCount(i);

            return result;
        }

    }
}