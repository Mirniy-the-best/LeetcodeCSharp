using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _1578
    {
        public int MinCost(string colors, int[] neededTime)
        {
            int l = 0, r = 1, s = 0;

            while (r < neededTime.Length) {
                if (colors[l] != colors[r]) {
                    l++; r++;
                    continue;
                }

                int max = neededTime[r - 1];
                while (r < colors.Length && colors[r] == colors[r-1])
                {
                    if (neededTime[r]>max)
                    {
                        s += max;
                        max = neededTime[r];
                    }
                    else { s+= neededTime[r]; }
                    r++;
                }
                l = r; r++;
            }
            return s;
        }
    }
}