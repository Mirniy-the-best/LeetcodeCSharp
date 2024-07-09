using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _1624
    {
        class pair
        {
            public char c { get; set; }
            public int Max { get; set; } = -1;
            public int Min { get; set; } = 10000;
            public void Update(int value)
            {
                if (value > Max) Max = value;
                if (value < Min) Min = value;
            }
        }
        public int MaxLengthBetweenEqualCharacters(string s)
        {
            var statistic = new Dictionary<char, pair>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!statistic.ContainsKey(s[i]))
                    statistic.Add(s[i], new pair { c = s[i] });
                statistic[s[i]].Update(i);
            }

            var res = statistic.Where(x => x.Value.Min >= 0 && x.Value.Max < s.Length).Max(x => x.Value.Max - x.Value.Min) -1;
            return res;
        }
    }
}