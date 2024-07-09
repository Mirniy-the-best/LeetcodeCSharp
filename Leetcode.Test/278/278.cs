using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _278
    {
        public int BadVersion { get; set; }
        bool IsBadVersion(int version)
        { return version >= BadVersion; }


        public int FirstBadVersion(int n)
        {
            if(n==1) return 1;
            int left = 0,
                right = n;
            int lastBad = -1;

            while (left<=right)
            {
                int middle = (int)(left/2.0 + right / 2.0);
                if (IsBadVersion(middle))
                {
                    lastBad = middle;
                    right = middle-1;
                }
                else left = middle + 1;
            }

            return lastBad;
        }
    }
}