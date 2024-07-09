using System.Linq;

namespace Leetcode.Test
{
    public class _151
    {
        public string ReverseWords(string s)
        {
            return string.Join(' ', s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse());
        }

    }
}