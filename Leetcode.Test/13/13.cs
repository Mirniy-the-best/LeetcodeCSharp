namespace Leetcode.Test
{
    public class _13
    {
        public int RomanToInt(string s)
        {
            var set = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            int sum = set[s[^1]];

            for (int i = s.Length - 2; i >= 0; i--)
            {
                if (set[s[i]] >= set[s[i + 1]]) sum += set[s[i]];
                else sum -= set[s[i]];
            }

            return sum;
        }
    }
}