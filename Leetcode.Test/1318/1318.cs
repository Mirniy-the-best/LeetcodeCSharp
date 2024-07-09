namespace Leetcode.Test
{
    public class _1318
    {
        public int MinFlips(int a, int b, int c)
        {
            int summ = 0;
            int ia, ib, ic;
            while (a != 0 || b !=0 || c != 0)
            {
                ia = a & 1;
                ib = b & 1;
                ic = c & 1;
                if (ic == 0) summ += ia + ib;
                if (ic == 1 && ia+ib == 0) summ += 1;
                a = a >> 1;
                b = b >> 1;
                c = c >> 1;
            }

           return summ;
        }

    }
}