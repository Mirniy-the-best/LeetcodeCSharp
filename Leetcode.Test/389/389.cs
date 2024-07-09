using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _389
    {
        public char FindTheDifference(string s, string t)
        {
            var s1 = new string(s.Order().ToArray());
            var s2 = new string(t.Order().ToArray());

            for (int i = 0; i < s1.Length; i++)
                if (s1[i] != s2[i]) return s2[i];
            return s2.Last();
        }

    }
}