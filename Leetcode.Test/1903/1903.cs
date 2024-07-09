using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _1903
    {
        public string LargestOddNumber(string num)
        {
            for (int i = num.Length - 1; i >= 0; i--)
                if (Char.GetNumericValue(num[i]) % 2 == 1)
                    return num.Substring(0, i + 1);

            return "";
        }
    }
}