namespace Leetcode.Test
{
    public class _2108
    {
        public string FirstPalindrome(string[] words)
        {
            foreach (var word in words)
            {
                if (word == new string(word.Reverse().ToArray()))
                    return word;
            }
            return "";
        }


    }
}