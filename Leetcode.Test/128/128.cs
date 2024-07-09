using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _128
    {
        public int LongestConsecutive(int[] nums)
        {
            var set = new PriorityQueue<int, int>(nums.Select(x => (x, x)));
            var max = 0;
            while (set.Count>0) {
                var item = set.Dequeue();
                var lmax = 1;
                while(set.TryPeek(out int ne, out int np))
                {
                    if (ne == item) { item = set.Dequeue(); continue; }
                    if (ne == item + 1) { lmax++; item = set.Dequeue(); }
                    else break;
                }
                if (lmax > max) max = lmax;
            }
            return max;
        }

    }
}