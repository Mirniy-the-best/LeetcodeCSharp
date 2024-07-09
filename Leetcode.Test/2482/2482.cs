using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _2482
    {
        public int[][] OnesMinusZeros(int[][] grid)
        {
            int n = grid.Length;
            int m = grid[0].Length;

            var rows = new int[n];
            var cols = new int[m];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (grid[i][j] != 0)
                    {
                        rows[i]++;
                        cols[j]++;
                    }


            int[][] diff = new int[n][];
            for (int i = 0; i < n; i++)
            {
                diff[i] = new int[m];
                int onesRow = 2 * rows[i] - n;

                for (int j = 0; j < m; j++)
                {
                    int onesCol = 2 * cols[j] - m;

                    diff[i][j] = onesRow + onesCol;
                }

            }
            return diff;
        }
    }
}