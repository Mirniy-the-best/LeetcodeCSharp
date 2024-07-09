using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _2610
    {
        public IList<IList<int>> FindMatrix(int[] nums)
        {
            var res = new List<HashSet<int>>();

            foreach (var num in nums)
            {
                bool isAdded = false;
                for (var i = 0; i < res.Count; i++)
                {
                    if (!res[i].Contains(num))
                    {
                        res[i].Add(num);
                        isAdded = true;
                        break;
                    }
                }
                if(!isAdded)
                {
                    res.Add(new HashSet<int> { num });
                }
            }

            return res
                .Select(x => x.ToList())
                .Cast<IList<int>>()
                .ToList();
        }
    }
}