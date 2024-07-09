using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _67
    {
        public string AddBinary(string a, string b)
        {
            if (b.Length > a.Length) { return AddBinary(b, a); }
            a = new string(a.ToString().Reverse().ToArray());
            b = new string(b.ToString().Reverse().ToArray());
            StringBuilder res = new StringBuilder();
            var extra = 0;

            for (var i = 0; i < a.Length; i++)
            {
                var num = extra;
                if (a[i] == '1') num++;
                if (i < b.Length && b[i] == '1') num++;
                res.Append(num % 2);
                extra = num / 2;
            }
            if(extra > 0) { res.Append("1"); }

            return new string(res.ToString().Reverse().ToArray());
        }
    }
}