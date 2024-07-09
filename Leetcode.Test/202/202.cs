using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _202
    {
        public bool IsHappy(int n)
        {
            var visited = new HashSet<int>();
            visited.Add(n);
            while (n!=1) {
                int s = 0;
                while (n>0) {
                    s += (n % 10) * (n % 10);
                    n /= 10;
                }
                if (visited.Contains(s)) { return false; }
                visited.Add(s);
                n = s;
            }
            return true;
        }

    }
}