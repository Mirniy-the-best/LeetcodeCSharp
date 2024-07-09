using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _1897
    {
        public bool MakeEqual(string[] words)
        {
            if(words.Length == 1) return true;
            var set= new Dictionary<char, int>();
            foreach (var word in words)
            {
                foreach (var c in word) {
                    if(!set.ContainsKey(c))
                        set.Add(c, 1);
                    else
                        set[c]++;
                }
            }
            return set.Values.All(x=>x%words.Length==0);
        }
    }
}