
namespace Leetcode.Test
{
    public class _1255
    {
        Dictionary<char, int> lib = new Dictionary<char, int>();

        public int MaxScoreWords(string[] words, char[] letters, int[] score)
        {
            var lets = new Dictionary<char, int>();

            foreach (var letter in letters) {
                lib[letter] = score[letter-'a'];
                lets[letter] = lets.GetValueOrDefault(letter)+1;
            }

            return search(words, lets);
        }

        int search(string[] words, Dictionary<char, int> letters, int p = 0, int sum = 0) {
            if ( p >= words.Length) return sum;

            int max = 0;
            for (int i = p; i < words.Length; i++)
            {
                var tletters = isConsist(words[i], letters.ToDictionary());
                if(tletters != null)
                {
                    var tsum = 0;
                    foreach (var c in words[i])
                        tsum += lib[c];

                    var tmp = search(words, tletters, i + 1, tsum);
                    max = Math.Max(max, tmp);
                }
            }
            return sum+max;
        }

        private Dictionary<char, int> isConsist(string v, Dictionary<char, int> dictionary)
        {
            foreach (var c in v)
                if (dictionary.GetValueOrDefault(c) > 0) dictionary[c]--;
                else return null;

            return dictionary;
        }
    }
}