using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _20
    {
        public bool IsValid(string s)
        {
            var map = new Dictionary<char, char>
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' }
            };

            var stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                { stack.Push(c); continue; }

                if (stack.Count == 0) return false;
                var last = stack.Pop();
                if (last != map[c]) return false;
            }
            return stack.Count == 0;
        }
    }
}