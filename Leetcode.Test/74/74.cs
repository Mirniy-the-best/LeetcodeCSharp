using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _74
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            if (target < matrix[0][0]) return false;
            if (target > matrix[matrix.Length-1][matrix[0].Length-1]) return false;

            int l = 0, r = matrix.Length - 1, row;
            while (l<=r)
            {
                row = l + (r - l) / 2;
                if (matrix[row][0] == target) return true;
                if (matrix[row][0] > target) r = row-1;
                else l = row+1;
            }
            row = r;

            l = 0;
            r = matrix[row].Length - 1;
            int m;
            while (l<=r)
            {
                m = l+(r-l)/2;
                if (matrix[row][m] == target) return true;
                if (matrix[row][m] > target) r = m-1;
                else l = m+1;
            }

            return false;
        }
    }
}