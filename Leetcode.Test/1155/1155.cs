using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _1155
    {
        int mod = 1000000007;
        public int NumRollsToTarget(int n, int k, int target)
        {
            if (n == 1) if (target > 0 && target <= k) return 1; else return 0;
            if (target > n * k) return 0;
            if (target == n * k) return 1;

            var lst = new int[target + 1];
            lst[0] = 1;
            int li;
            for (int nc = 0; nc < n; nc++)
            {
                for (int i = target; i >= 0; i--)
                {
                    li = 0;
                    for (int j = 1; j <= k && j<=i; j++)
                        li = (li + lst[i - j])%mod;
                    lst[i] = li;
                }
            }
            return lst[target];
        }
    }
}