namespace Leetcode.Test
{
    public class _76
    {
        public string MinWindow(string s, string t)
        {
            var index = new Dictionary<char, int>();
            foreach (char c in t)
                index[c] = index.GetValueOrDefault(c) + 1;

            int l = 0;
            int maxl = -1;
            int maxr = s.Length + 1;

            while (l < s.Length)
            {
                if (index.ContainsKey(s[l]))
                {
                    maxl = l;
                    break;
                }
                l++;
            }

            for (int r = l; r < s.Length; r++)
            {
                if (!index.ContainsKey(s[r]))
                    continue;

                index[s[r]]--;
                if (index[s[r]] <= 0
                    && index.All(x => x.Value <= 0)
                    && r - l < maxr - maxl)
                {
                    maxl = l;
                    maxr = r + 1;
                }


                while (l < r)
                {
                    if (!index.ContainsKey(s[l]))
                    {
                        l++;
                        continue;
                    }

                    if (index[s[l]] > 0) break;
                    if (index.All(x => x.Value <= 0)
                        && r - l < maxr - maxl)
                    {
                        maxl = l;
                        maxr = r + 1;
                    }
                    if (index[s[l]] == 0)
                        break;

                    index[s[l]]++;
                    l++;
                }
            }

            if (maxr > s.Length)
                return "";

            return s.Substring(maxl, maxr - maxl);
        }

    }
}