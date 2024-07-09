namespace Leetcode.Test
{
    public class _1684
    {
        public int CountConsistentStrings(string allowed, string[] words)
        {
            int cnt = 0;
            var set = new HashSet<char>(allowed);

            foreach (string w in words)
            {
                int i = 0;
                for (; i < w.Length; i++)
                {
                    if (!set.Contains(w[i])) break;
                }
                if (i == w.Length) cnt++;
            }

            return cnt;
        }

    }
}