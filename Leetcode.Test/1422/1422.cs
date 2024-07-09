using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _1422
    {
        public int MaxScore(string s)
        {
            int maxrate = s.Skip(1).Count(x=> x == '1');
            if (s[0] == '0') maxrate++;
            int rate = maxrate;

            for (int i = 1; i < s.Length-1; i++)
            {
                if (s[i] == '0')
                {
                    rate++;
                    if(rate > maxrate) maxrate = rate;
                }
                else
                {
                    rate--;
                }
            }
            return maxrate;
        }
    }
}