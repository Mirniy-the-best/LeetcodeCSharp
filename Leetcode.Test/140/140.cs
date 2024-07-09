namespace Leetcode.Test
{
    public class _140
    {
        public IList<string> WordBreak(string s, IList<string> wordDict)
        {
            return search(s, 0, [.. wordDict.OrderBy(x => x.Length)], []);
        }

        List<string> search(string s, int p, List<string> words, List<string> res) {
            if (p == s.Length) return [string.Join(' ', res)];

            var lst = new List<string>();
            string word = "";
            for (int i = p; i < s.Length; i++)
            {
                word += s[i];
                for (int j = 0; j < words.Count; j++)
                {
                    if (words[j] == word)
                    {
                        var bulk = search(s, i + 1, words, [.. res, word]);
                        lst.AddRange(bulk);
                    }
                }
            }

            return lst;
        }

    }
}