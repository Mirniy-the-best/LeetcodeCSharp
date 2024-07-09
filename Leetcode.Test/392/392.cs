namespace Leetcode.Test
{
    public class _392
    {
        public bool IsSubsequence(string s, string t)
        {
            if (s.Length == 0) return true;
            if (s.Length > t.Length) return false;
            int ps = 0;

            for (int i = 0; i < t.Length; i++)
            {
                if (s[ps] == t[i])
                {
                    ps++;
                    if (ps == s.Length)
                        return true;
                }
            }

            return ps >= s.Length;
        }

    }
}