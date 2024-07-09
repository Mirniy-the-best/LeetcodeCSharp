using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _1758
    {
        public int MinOperations(string s)
        {
            int cnt0 = 0;
            for (int i = 0; i < s.Length; i+=2)
                if (s[i] != '0') cnt0++;
            for (int i = 1; i < s.Length; i += 2)
                if (s[i] != '1') cnt0++;
            return Math.Min(cnt0, s.Length-cnt0);
        }
    }
}