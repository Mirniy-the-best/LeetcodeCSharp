namespace Leetcode.Test
{
    public class _7
    {
        public int Reverse(int x)
        {
            if (x < 0)
                if (-x < 0) return 0;
                else return -Reverse(-x);

            var r = 0;
            for (int i = 0; x > 0; i++)
            {
                if (i == 9 && r > int.MaxValue / 10) return 0;
                r = r * 10 + x % 10;
                x /= 10;
            }
            return r;
        }


    }
}