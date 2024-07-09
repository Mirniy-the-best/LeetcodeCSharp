namespace Leetcode.Test
{
    public class _2582
    {
        public int PassThePillow(int n, int time)
        {

            var p = time / n;
            var q = time % n;
            n--;
            if ((time / n) % 2 == 0)
                if(time / n > 0)
                    return time % n + 1;
                else
                    return time % n + 1;

            return n - time % n + 1;
        }


    }
}