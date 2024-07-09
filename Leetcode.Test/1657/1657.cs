namespace Leetcode.Test
{
    public class _1657
    {
        public bool CloseStrings(string word1, string word2)
        {
            if (word1.Length != word2.Length) return false;

            var set1 = new Dictionary<char, int>();
            var set2 = new Dictionary<char, int>();

            for (int i = 0; i < word1.Length; i++)
            {
                if (!set1.ContainsKey(word1[i]))
                    set1.Add(word1[i], 1);
                else
                    set1[word1[i]]++;

                if (!set2.ContainsKey(word2[i]))
                    set2.Add(word2[i], 1);
                else
                    set2[word2[i]]++;
            }

            return Enumerable.SequenceEqual(set1.Values.Order(), set2.Values.Order())
                & Enumerable.SequenceEqual(set1.Keys.Order(), set2.Keys.Order());
        }

    }
}