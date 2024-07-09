namespace Leetcode.Test
{
    public class _1704
    {
        public bool HalvesAreAlike(string s)
        {
            var dictionary = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int comparer = 0;
            for (int i = 0; i < s.Length/2; i++)
            {
                if (dictionary.Contains(s[i])) comparer++;
                if (dictionary.Contains(s[s.Length - i-1])) comparer--;
            }
            return comparer == 0;
        }

    }
}