using System.Text;

namespace Leetcode.Test
{
    public class _2390
    {
        public string RemoveStars(string s)
        {
            var _stack = new Stack<char>();
            foreach (char c in s)
            {
                if(c == '*')
                    _stack.Pop();
                else
                    _stack.Push(c);
            }
           
            return new string(_stack.Reverse().ToArray());
        }

    }
}