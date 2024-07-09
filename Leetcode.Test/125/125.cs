using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _125
    {
        public bool IsPalindrome(string s)
        {
            var i = 0;
            var j = s.Length-1;
            while (i < j)
            {
                while (!char.IsLetterOrDigit(s[i]) && i < j) { i++; }
                while (!char.IsLetterOrDigit(s[j]) && i < j) { j--; }
                if (char.ToLower(s[i]) != char.ToLower(s[j]))
                    return false;
                i++;
                j--;
            }
            return true;
        }
    }
}