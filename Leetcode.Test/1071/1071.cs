using System.Numerics;

namespace Leetcode.Test
{
    public class _1071
    {
        public string GcdOfStrings(string str1, string str2)
        {
            if (str1 + str2 != str2 + str1)
                return "";

            var len = BigInteger.GreatestCommonDivisor(str1.Length, str2.Length);
            return str1.Substring(0, (int)len);
        }

    }
}