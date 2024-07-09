using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _2706
    {
        public int BuyChoco(int[] prices, int money)
        {
           var p = new PriorityQueue<int,int>();
            foreach (var pr in prices)
                p.Enqueue(pr, pr);

            var sum = p.Dequeue() + p.Dequeue();
            if(sum>money) { return money; }
            else { return money - sum; }
        }
    }
}