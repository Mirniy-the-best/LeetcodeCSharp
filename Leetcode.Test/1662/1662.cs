namespace Leetcode.Test
{
    public class _1662
    {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            return String.Compare(String.Concat(word1), String.Concat(word2)) == 0;
        }

    }
}