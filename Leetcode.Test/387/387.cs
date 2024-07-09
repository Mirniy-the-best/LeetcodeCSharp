namespace Leetcode.Test
{
    public class _387
    {
        public int FirstUniqChar(string s)
        {
            var index = new Dictionary<char, int>();
            foreach (var c in s)
                index[c] = index.GetValueOrDefault(c) + 1;
            for (var i = 0; i < s.Length; i++)
                if (index[s[i]] == 1)
                    return i;
            return -1;
        }

    }
}