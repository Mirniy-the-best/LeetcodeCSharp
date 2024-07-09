using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _383
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            var index = new Dictionary<char, int>();
            foreach (char c in magazine)
            {
                if (index.ContainsKey(c)) index[c]++;
                else index.Add(c, 1);
            }
            foreach (char c in ransomNote)
            {
                if (!index.ContainsKey(c) || index[c] == 0)
                    return false;
                else index[c]--;
            }
            return true;
        }

    }
}