namespace Leetcode.Test
{
    public class _345
    {
        public string ReverseVowels(string s)
        {
            var sa = s.ToCharArray();
            var set = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int l = 0;
            int r = sa.Length - 1;
            while (l < r)
            {
                while (l < r && !set.Contains(sa[l])) l++;
                while (l < r && !set.Contains(sa[r])) r--;

                if (l < r)
                    (sa[l], sa[r]) = (sa[r], sa[l]);
                l++;
                r--;
            }
            return new string(sa);
        }

    }
}