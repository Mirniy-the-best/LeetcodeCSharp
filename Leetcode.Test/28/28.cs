namespace Leetcode.Test
{
    public class _28
    {
        public int StrStr(string haystack, string needle)
        {
            for (int i = needle.Length - 1; i < haystack.Length; i++)
            {
                int j = 0;
                for (; j < needle.Length; j++)
                    if (haystack[i - needle.Length + 1 + j] != needle[j])
                        break;

                if (j == needle.Length)
                    return i - needle.Length + 1;
            }
            return -1;
        }

    }
}