using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _1637
    {
        public int MaxWidthOfVerticalArea(int[][] points)
        {
            var max = 0;
            var heap = new PriorityQueue<int, int>(points.Select(x => (x[0], x[0])));
            var prev = heap.Dequeue();
            do
            {
                var cur = heap.Dequeue();
                max = Math.Max(max, cur - prev);
                prev = cur;
            } while (heap.Count > 0);

            return max;
        }
    }
}