namespace Leetcode.Test
{
    public class _131
    {
        public IList<IList<string>> Partition(string s)
        {
            var res = new List<IList<string>>();
            search(s, res, new List<string>());
            return res;
        }

        IList<IList<string>> search(string s, List<IList<string>> r, List<string> res)
        {
            if (s.Length == 0)
            {
                r.Add(res);
                return r;
            }

            for (int j = 1; j <= s.Length; j++)
            {
                var ts = s.Substring(0, j);
                if (IsPalindrome(ts))
                {
                    search(s.Substring(j), r, res.Append(ts).ToList());
                }
            }
            return r;
        }

        bool IsPalindrome(string s)
        {
            int l = 0, r = s.Length - 1;
            while (l <= r)
            {
                if (s[l] != s[r]) return false;
                l++; r--;
            }
            return true;
        }
    }
}