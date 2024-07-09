namespace Leetcode.Test
{
    public class _14
    {
        public string LongestCommonPrefix(string[] strs)
        {
            int n = strs[0].Length;
            for (int i = 1; i<strs.Length; i++)
            {
                n = Math.Min(strs[i].Length, n);
                for(int j = 0; j < n; j++)
                {
                    if (strs[i][j] != strs[i - 1][j])
                    {
                        n = j;
                        if (j > 0)
                            break;
                        else
                            return "";
                    }
                }
            }
            return strs[0].Substring(0,n);
        }

    }
}