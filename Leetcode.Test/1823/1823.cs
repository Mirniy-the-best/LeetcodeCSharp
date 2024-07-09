namespace Leetcode.Test
{
    public class _1823
    {
        public int FindTheWinner(int n, int k)
        {
            var res = 0;
            for (int i = 1; i<=n; i++)
                res = (res+k)%i;

            return res+1;
        }


    }
}