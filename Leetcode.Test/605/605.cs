using System.Runtime.Intrinsics.X86;

namespace Leetcode.Test
{
    public class _605
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            if (n == 0) return true;
            if (flowerbed.Length == 1)
                return flowerbed[0] == 0;

            int cnt = 0;
            if (flowerbed[0] == 0 && flowerbed[1] == 0)
                cnt++;

            for (int i = 2; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0 && flowerbed[i - 1] == 0 && (i == flowerbed.Length-1 || flowerbed[i + 1] == 0))
                {
                    cnt++;
                    i++;
                    if (cnt >= n) return true;
                }
            }
            return cnt >= n;
        }

    }
}