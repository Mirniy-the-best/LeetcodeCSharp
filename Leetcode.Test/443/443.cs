using System.Globalization;

namespace Leetcode.Test
{
    public class _443
    {
        public int Compress(char[] chars)
        {
            int l = 0;
            int cnt = 1;
            char c = chars[0];

            for (int r = 1; r < chars.Length; r++)
            {
                if (chars[r] == c)
                {
                    cnt++;
                    continue;
                }

                if (chars.Length - cnt >= l)
                    chars[l] = c;
                l++;
                if (cnt > 1)
                {
                    foreach (var i in cnt.ToString())
                    {
                        chars[l] = i;
                        l++;
                    }
                }
                c = chars[r];
                cnt = 1;
            }

            if (chars.Length - cnt >= l)
            {
                chars[l] = c;
                l++;
                if (cnt > 1)
                {
                    foreach (var i in cnt.ToString())
                    {
                        chars[l] = i;
                        l++;
                    }
                }
                return l;
            }
            return l+1;
        }

    }
}