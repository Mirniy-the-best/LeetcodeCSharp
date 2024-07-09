namespace Leetcode.Test
{
    public class _680
    {
        public bool ValidPalindrome(string s, bool isChanse = true)
        {
            int l = 0, r = s.Length - 1;
            while (l < r)
            {
                if (s[l] == s[r])
                {
                    l++;
                    r--;
                    continue;
                }

                if (!isChanse)  return false;

                return ValidPalindrome(s.Substring(l + 1, r - l), false)
                    || ValidPalindrome(s.Substring(l, r - l), false);
            }

            return true;
        }


    }
}