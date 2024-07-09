using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _205
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length) return false;
            var sindex = new Dictionary<char, char>();
            var tindex = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!sindex.ContainsKey(s[i]) && !tindex.ContainsKey(t[i]))
                {
                    sindex.Add(s[i], t[i]);
                    tindex.Add(t[i], s[i]);
                    continue;
                }
                if (!sindex.ContainsKey(s[i])
                    || !tindex.ContainsKey(t[i])
                    || sindex[s[i]] != t[i]
                    || tindex[t[i]] != s[i])
                return false;
            }
            return true;
        }

    }
}