using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _1287
    {
        public int FindSpecialInteger(int[] arr)
        {
            var index = new Dictionary<int, int>();
            foreach (var item in arr)
            {
                if (index.ContainsKey(item))
                    index[item]++;
                else
                { index[item] = 1; }
            }

            return index.OrderByDescending(x=>x.Value).First().Key;
        }
    }
}