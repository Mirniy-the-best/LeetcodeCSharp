using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _3
    {
        public int LengthOfLongestSubstring(string s)
        {
            var max = 0;
            int l = 0;
            var set= new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                while (set.Contains(s[i]))
                {
                    set.Remove(s[l]);
                    l++;
                }

                set.Add(s[i]);
                max = Math.Max(max, set.Count);
            }
            return max;
        }
    }
}