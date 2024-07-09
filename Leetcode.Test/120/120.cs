using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _120
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            for (int i = 1; i < triangle.Count; i++)
            {
                triangle[i][0] += triangle[i-1][0];
                triangle[i][triangle[i].Count - 1] += triangle[i - 1][triangle[i-1].Count - 1];
                for (int j = 1; j < triangle[i].Count-1; j++)
                    triangle[i][j] += Math.Min(triangle[i - 1][j], triangle[i - 1][j-1]);
            }
            return triangle.Last().Min();
        }
    }
}