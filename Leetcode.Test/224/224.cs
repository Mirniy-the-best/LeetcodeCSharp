using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _224
    {
        Stack<char> operation = new Stack<char>();
        Stack<int> nums = new Stack<int>();

        public int Calculate(string s)
        {
            int num = 0;
            bool isSign = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsWhiteSpace(s[i]))
                    continue;

                if(s[i] == '+')
                {
                    operation.Push(s[i]);
                    continue;
                }
                if (s[i] == '(')
                {
                    isSign = true;
                    operation.Push(s[i]);
                    continue;
                }

                if(s[i] == '-')
                {
                    if (isSign)
                        nums.Push(0);
                    operation.Push(s[i]);
                    continue;
                }

                if (s[i]==')')
                {
                    operation.Pop();
                    Calc();
                    continue;
                }

                if (char.IsDigit(s[i]))
                {
                    num = num * 10 + (int)char.GetNumericValue(s[i]);
                    if (i == s.Length - 1 || !char.IsDigit(s[i + 1]))
                    {
                        nums.Push(num);
                        num = 0;
                        isSign = false;
                        Calc();
                    }
                }
            }
            return nums.Pop();
        }

        private void Calc()
        {
            while (operation.Any() && operation.Peek() != '(')
            {
                var op = operation.Pop();
                if(op == '+')
                {
                    nums.Push(nums.Pop() + nums.Pop());
                    continue;
                }

                if (op == '-')
                {
                    var n2 = nums.Pop();
                    var n1 = nums.Any() ? nums.Pop() : 0;
                    nums.Push(n1 - n2);
                    continue;
                }
            }
        }
    }
}