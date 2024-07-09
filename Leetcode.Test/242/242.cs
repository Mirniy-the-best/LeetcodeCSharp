using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _242
    {
        public bool IsAnagram(string s, string t)
        {
            var cnt1 = new Dictionary<char, int>();
            foreach (var item in s)
            {
                if (!cnt1.ContainsKey(item))
                {
                    cnt1.Add(item, 1);
                }
                else
                {
                    cnt1[item]++;
                }
            }

            var cnt2 = new Dictionary<char, int>();
            foreach (var item in t)
            {
                if (!cnt2.ContainsKey(item))
                {
                    cnt2.Add(item, 1);
                }
                else
                {
                    cnt2[item]++;
                }
            }

            if (cnt1.Count != cnt2.Count)
                return false;

            if (cnt1.Except(cnt2).Any())
                return false;
            if (cnt2.Except(cnt1).Any())
                return false;

            return true;
        }
    }
}