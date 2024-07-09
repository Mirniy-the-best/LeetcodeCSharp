using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _290
    {
        public bool WordPattern(string pattern, string s)
        {
            var words = s.Split();
            if (words.Length != pattern.Length) return false;

            var pindex = new Dictionary<char, string>();
            var sindex = new Dictionary<string, char>();
            for (int i = 0; i<pattern.Length; i++)
            {
                if (!pindex.ContainsKey(pattern[i]) && !sindex.ContainsKey(words[i]))
                {
                    pindex.Add(pattern[i], words[i]);
                    sindex.Add(words[i], pattern[i]);
                    continue;
                }

                if (!pindex.ContainsKey(pattern[i])
                    || !sindex.ContainsKey(words[i])
                    || !string.Equals(pindex[pattern[i]], words[i])
                    || sindex[words[i]] != pattern[i])
                    return false;
            }
            return true;
        }

    }
}