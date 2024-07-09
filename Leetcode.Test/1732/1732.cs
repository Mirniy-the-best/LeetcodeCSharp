using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _1732
    {
        public int LargestAltitude(int[] gain)
        {
            int max = 0, s = 0;
            for (var i = 0; i < gain.Length; i++)
            {
                s += gain[i];
                if (s > max) max = s;
            }
            return max;
        }

    }
}