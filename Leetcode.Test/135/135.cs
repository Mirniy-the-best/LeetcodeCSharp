using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _135
    {
        public int Candy(int[] ratings)
        {
            var summ = new int[ratings.Length];
            summ[0] = 1;
            for (int i = 1; i < ratings.Length; i++)
            {
                if (ratings[i] > ratings[i-1])
                {
                    summ[i] = summ[i - 1] + 1;
                    continue;
                }
                if (ratings[i] == ratings[i - 1])
                {
                    summ[i] = 1;
                    continue;
                }

                summ[i] = 1;
                int j = i - 1;
                while (j >= 0
                    && ratings[j] > ratings[j + 1]
                    && summ[j] <= summ[j + 1])
                {
                    summ[j]++;
                    j--;
                }
            }

            return summ.Sum();
        }
    }
}