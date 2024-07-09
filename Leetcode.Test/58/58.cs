using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _58
    {
        public int LengthOfLastWord(string s)
        {
            int r = s.Length - 1;
            while (!char.IsLetter(s[r])) { r--; }
            int l = r-1;
            while (l >= 0 && char.IsLetter(s[l])) { l--; }
            return r-l;
        }
    }
}