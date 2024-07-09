namespace Leetcode.Test
{
    public class _2000
    {
        public string ReversePrefix(string word, char ch)
        {
            int p = word.IndexOf(ch);
            var rres = word.Substring(0, p + 1).Reverse().Concat(word.Substring(p + 1, word.Length - p - 1));
            return new string(rres.ToArray());
        }


    }
}