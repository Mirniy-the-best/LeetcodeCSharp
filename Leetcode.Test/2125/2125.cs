using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _2125
    {
        public int NumberOfBeams(string[] bank)
        {
            int sum = 0;
            int previous = 0;
            foreach (var item in bank)
            {
                var cnt = item.Count(x => x.Equals('1'));
                if (cnt == 0)
                    continue;
                sum += previous * cnt;
                previous = cnt;
            }
            return sum;
        }
    }
}