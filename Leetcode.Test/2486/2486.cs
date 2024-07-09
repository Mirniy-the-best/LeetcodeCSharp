namespace Leetcode.Test
{
    public class _2486
    {
        public int AppendCharacters(string s, string t)
        {
            int r = 0;

            for (int i = 0; i < s.Length && r<t.Length; i++)
                if (s[i] == t[r]) r++;

            return t.Length - r;

        }


    }
}