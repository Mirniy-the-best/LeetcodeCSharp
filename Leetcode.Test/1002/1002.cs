namespace Leetcode.Test
{
    public class _1002
    {
        public IList<string> CommonChars(string[] words)
        {
            var set = GetIndex(words[0]);

            for (int i = 1; i < words.Length; i++)
                set = Intersect(set, GetIndex(words[i]));

            return set
                .SelectMany(x => Enumerable.Repeat($"{x.Key}", x.Value))
                .ToList();

            static Dictionary<char, int> GetIndex(string word)
            {
                var set = new Dictionary<char, int>();
                foreach (var c in word)
                    set[c] = set.GetValueOrDefault(c) + 1;
                return set;
            }

            static Dictionary<char, int> Intersect(Dictionary<char, int> set, Dictionary<char, int> ind)
            {
                foreach (var item in set)
                    set[item.Key] = Math.Min(ind.GetValueOrDefault(item.Key), item.Value);

                return set.Where(x => x.Value > 0).ToDictionary();
            }
        }
    }
}