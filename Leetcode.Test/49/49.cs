using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _49
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var index = new Dictionary<string, IList<string>>();
            foreach (var str in strs)
            {
                var s = new string(str.OrderBy(x=>x).ToArray());
                if (index.ContainsKey(s)) index[s].Add(str);
                else index.Add(s, new List<string>(new[] { str }));
            }
            return index.Select(x => x.Value).ToList();
        }

    }
}