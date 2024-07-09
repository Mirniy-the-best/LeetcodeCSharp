namespace Leetcode.Test
{
    public class _1404
    {
        public int NumSteps(string s)
        {
            int cnt = 0;

            bool extra = false;
            for (int i = s.Length - 1; i > 0; i--)
            {
                cnt++;

                if (s[i] == '0' && extra)
                    cnt++;

                if (s[i] == '1' && !extra)
                {
                    cnt++;
                    extra = true;
                }
            }

            if(extra) cnt++;

            return cnt;
        }


    }
}