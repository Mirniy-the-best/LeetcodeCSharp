using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _661
    {
        public int[][] ImageSmoother(int[][] img)
        {
            int n = img.Length;
            int m = img[0].Length;

            int[][] res = new int[n][];

            for (int i = 0;i<n; i++)
            {
                res[i] = new int[m];
                for (int j = 0;j<m; j++)
                {
                    int cnt = 1;
                    var sum = img[i][j];

                    if (i > 0)
                    {
                        sum += img[i - 1][j]; cnt++;
                    }
                    if (i < n-1)
                    {
                        sum += img[i + 1][j]; cnt++;
                    }
                    if (j > 0)
                    {
                        sum += img[i][j-1]; cnt++;
                    }
                    if (j < m - 1)
                    {
                        sum += img[i][j+1]; cnt++;
                    }

                    if(i>0 && j>0)
                    {
                        sum += img[i-1][j - 1]; cnt++;
                    }

                    if (i < n-1 && j < m-1)
                    {
                        sum += img[i + 1][j + 1]; cnt++;
                    }

                    if (i > 0 && j < m - 1)
                    {
                        sum += img[i - 1][j + 1]; cnt++;
                    }

                    if (i < n - 1 && j > 0)
                    {
                        sum += img[i + 1][j - 1]; cnt++;
                    }

                    res[i][j] = sum / cnt;
                }
            }

            return res;
        }
    }
}