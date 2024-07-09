namespace Leetcode.Test
{
    public class _1347
    {
        public int MinSteps(string s, string t)
        {
            var template = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (template.ContainsKey(s[i]))
                    template[s[i]]++;
                else template.Add(s[i], 1);
            }

            var cnt = 0;
            for (int i = 0; i<t.Length; i++)
            {
                if (template.ContainsKey(t[i]) && template[t[i]]>0)
                    template[t[i]]--;
                else
                    cnt++;
            }
            return cnt;
        }

    }
}