using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _9
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            var src = x;
            var num = 0;
            while(src >= 10)
            {
                num *= 10;
                num += src % 10;
                src /= 10;
            }
            num *= 10;
            num += src;

            return num == x;
        }
    }
}