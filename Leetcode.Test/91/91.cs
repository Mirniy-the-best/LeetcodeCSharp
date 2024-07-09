using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _91
    {
        public int NumDecodings(string s)
        {
            if (s[0] == '0') return 0;
            int[] d = new int[s.Length+1];
            d[0] = 1;

            for (int i = 1; i < s.Length; i++)
            {
                if (set.Contains(s[i].ToString()))
                    d[i] += d[i - 1];

                if (set.Contains($"{s[i - 1]}{s[i]}"))
                    if (i > 1)
                        d[i] += d[i - 2];
                    else
                        d[i] += 1;
            }
            return d[s.Length-1];
        }

        HashSet<string> set = new HashSet<string>() { "1", "2","3","4","5","6","7","8","9","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26" };
    }
}