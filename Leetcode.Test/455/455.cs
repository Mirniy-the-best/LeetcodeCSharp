using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _455
    {
        public int FindContentChildren(int[] g, int[] s)
        {
            var children = new PriorityQueue<int, int>(g.Select(x => (x, x)));
            var sizes = new PriorityQueue<int, int>(s.Select(x => (x, x)));

            int cnt = 0;
            while (children.Count > 0 && sizes.Count > 0) {
                var c = children.Peek();
                var size = sizes.Dequeue();
                if (size >= c) {
                    cnt++;
                    children.Dequeue();
                }
            }
            return cnt;
        }
    }
}