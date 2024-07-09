using System.Globalization;

namespace Leetcode.Test
{
    public class _875
    {
        public int MinEatingSpeed(int[] piles, int h)
        {
            return Search(piles, h);
        }

        int Search(int[] piles, int h)
        {
            int l = 1;
            int r = piles.Max();
            while(l < r) {
                int m = l + (r - l) / 2;
                if (!isHaveTimeToEat(piles, h, m))
                    l = m + 1;
                else
                {
                    if (isHaveTimeToEat(piles, h, m) && (m == 1 || !isHaveTimeToEat(piles, h, m - 1)))
                        return m;
                    else
                        r = m - 1;
                }
            }
            return r;
        }

        bool isHaveTimeToEat(int[] piles, int h, int k)
        {
            int cnt = 0;
            foreach (int i in piles)
            {
                cnt += (int)Math.Ceiling(i*1.0 / k);
                if (cnt > h) return false;
            }
            return true;
        }

    }
}