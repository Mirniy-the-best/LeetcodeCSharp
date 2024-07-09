namespace Leetcode.Test
{
    public class _409
    {
        public int LongestPalindrome(string s)
        {
            var map = new Dictionary<char, int>();
            foreach (char c in s)
                map[c] = map.GetValueOrDefault(c)+1;

            int len = 0;
            foreach (var item in map)
                len += item.Value % 2 == 0 ? item.Value : item.Value - 1;

            if (map.Any(item => item.Value % 2 == 1))
                len++;

            return len;
        }


    }
}