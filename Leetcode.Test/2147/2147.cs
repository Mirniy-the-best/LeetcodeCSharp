using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _2147
    {
        ulong mod = 1000000007;
        public int NumberOfWays(string corridor)
        {
            if (corridor.Count(x => x == 'S') % 2 == 1) return 0;
            ulong cnt = 0;
            var tc = 0;
            int r;
            for (r = corridor.Length - 1; r >= 0; r--)
            {
                if (corridor[r] == 'S')
                    tc++;

                if (tc == 2)
                {
                    cnt++;
                    break;
                }
            }

            tc = 0;
            int changes = 0;
            for (var l = 0; l < r; l++)
            {
                if (corridor[l] == 'S')
                    if (tc < 2)
                    {
                        tc++;
                        continue;
                    }
                    else
                    {
                        cnt = (cnt*(ulong)(changes + 1))%mod;
                        tc = 1;
                        changes = 0;
                    }

                if(corridor[l] == 'P' && tc == 2) changes++;
            }

            if (changes > 0) { cnt = (cnt * (ulong)(changes + 1))%mod; }

            return (int)cnt;
        }
    }
}