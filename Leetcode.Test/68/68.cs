using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _68
    {
        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            var res = new List<string>();
            var lst = new List<string>() { words[0] };
            var len = words[0].Length;
            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length+1 == maxWidth - len)
                {
                    len += words[i].Length;
                    if (lst.Any()) len++;
                    lst.Add(words[i]);
                    res.Add(Justify(lst, len, maxWidth, i==words.Length-1));
                    lst.Clear();
                    len = 0;
                    continue;
                }
                if (words[i].Length+1 > maxWidth - len)
                {
                    res.Add(Justify(lst, len, maxWidth));
                    lst.Clear();
                    lst.Add(words[i]);
                    len = words[i].Length;
                    continue;
                }

                len += words[i].Length;
                if (lst.Any()) len++;
                lst.Add(words[i]);

            }

            if (lst.Any())
                res.Add(Justify(lst, len, maxWidth, true));

            return res;
        }

        private string Justify(List<string> lst, int len, int maxWidth, bool isLast = false)
        {
            var spaces = maxWidth - len;
            if(lst.Count==1)
                return new StringBuilder(lst[0]).Append(' ', spaces).ToString();
            if(isLast)
                return new StringBuilder(string.Join(" ", lst)).Append(' ', spaces).ToString();

            var mspaces = spaces/(lst.Count-1);
            var espaces = spaces % (lst.Count - 1);
            var res = new StringBuilder();
            res.Append(lst[0]);

            foreach (var s in lst.Skip(1))
            {
                res.Append(' ', mspaces + 1);
                if (espaces > 0)
                {
                    res.Append(' ');
                    espaces--;
                }
                res.Append(s);
            }
            return res.ToString();
        }
    }
}