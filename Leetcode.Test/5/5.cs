namespace Leetcode.Test
{
    public class _5
    {
        public string LongestPalindrome(string s)
        {
            int max = 0;
            int lmax = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int l = i, r = i + 1;
                int cnt = 0;
                while (l >= 0 && r < s.Length && s[l] == s[r])
                {
                    l--;
                    r++;
                    cnt += 2;
                }
                if (cnt > max)
                {
                    max = cnt;
                    lmax = l+1;
                }

                l = i - 1;
                r = i + 1;
                cnt = 1;
                while (l >= 0 && r < s.Length && s[l] == s[r])
                {
                    l--;
                    r++;
                    cnt += 2;
                }
                if (cnt > max)
                {
                    max = cnt;
                    lmax = l + 1;
                }
            }
            return s.Substring(lmax, max);
        }


    }
}