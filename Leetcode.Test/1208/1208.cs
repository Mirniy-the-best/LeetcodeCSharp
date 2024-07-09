namespace Leetcode.Test
{
    public class _1208
    {
        public int EqualSubstring(string s, string t, int maxCost)
        {
            int l = 0;
            int r = 0;
            int lenth = 0;
            int maxLenth = 0;

            while (r < t.Length)
            {
                var rSumm = Math.Abs(s[r] - t[r]);

                if (rSumm <= maxCost || l == r)
                {
                    r++;
                    lenth++;
                    maxCost -= rSumm;
                    if(maxCost >= 0)
                        maxLenth = Math.Max(maxLenth, lenth);
                }
                else
                {
                    var lSumm = Math.Abs(s[l] - t[l]);
                    maxCost += lSumm;
                    lenth--;
                    l++;
                }
            }

            return maxLenth;
        }


    }
}