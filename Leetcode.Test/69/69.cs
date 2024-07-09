using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _69
    {
        public int MySqrt(int x)
        {
            if (x == 0) return 0;
            if (x == 1) return 1;

            int r = x >> 1;
            int l = 1;
            var ux = (ulong)x;
            ulong rr = (ulong)r * (ulong)r;
            if (rr <= ux && rr > 0)
                return r;
            do {
                var rc = (r + l) >> 1;
                rr = (ulong)rc * (ulong)rc;

                if(rr == ux) return rc;
                if (rr > ux || rr < 0) r = rc;
                if (rr < ux && rr > 0) l= rc;
            } while (r - l > 1 && rr != ux);
            return l;
        }
    }
}