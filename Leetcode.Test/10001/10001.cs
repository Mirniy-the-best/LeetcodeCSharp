namespace Leetcode.Test
{
    public class _10001
    {
        public string ClearDigits(string s)
        {

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    s = s.Remove(i, 1);
                    for (int j = i-1; j >= 0; j--)
                        if (!char.IsDigit(s[j]))
                        {
                            s = s.Remove(j, 1);
                            break;
                        }
                    i-=2;
                }
            }
            return s;
        }


    }
}