using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _70
    {
        public int ClimbStairs(int n)
        {
            var st = new int[n+1];
            st[0] = 1;
            st[1] = 1;
            for (var i = 2; i< st.Length; i++)
                st[i] = st[i-1] + st[i - 2];
            return st[n];
        }
    }
}