namespace Leetcode.Test
{
    public class _42
    {
        public int Trap(int[] height)
        {
            var sum = 0;
            int l = 0;
            int maxl = l;
            int r = height.Length-1;
            int maxr = r;

            while (l < r)
            {
                if (height[maxl] < 1) { maxl++; l++; continue; }
                if (height[maxr] < 1) { maxr--; r--; continue; }

                if (height[maxr] > height[maxl])
                {
                    if (height[l] > height[maxl])
                    {
                        maxl = l;
                        continue;
                    }
                    if (height[l] < height[maxl])
                        sum += height[maxl] - height[l];
                    l++;
                    continue;
                }

                if (height[r] > height[maxr])
                {
                    maxr = r;
                    continue;
                }
                if (height[r] < height[maxr])
                    sum += height[maxr] - height[r];
                r--;
            }
            return sum;
        }
    }
}