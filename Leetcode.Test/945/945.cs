namespace Leetcode.Test
{
    public class _945
    {
        public int MinIncrementForUnique(int[] nums)
        {
            var index = new int[100001];
            int minvalue = 9999999;
            int maxvalue = -1;
            int sum = 0;
            int max = 0;

            foreach (int x in nums)
            {
                index[x]++;
                if(x < minvalue) minvalue = x;
                if(x > maxvalue) maxvalue = x;
            }

            int cnt = 0;
            for (int i = minvalue;i <= maxvalue; i++)
            {
                if (index[i] > 0)
                {
                    cnt += index[i] - 1;
                    sum += cnt;
                    if(sum > max) max = sum;
                }
                else
                {
                    cnt = Math.Max(cnt - 1, 0);
                    sum += cnt;
                }
            }

            while(cnt > 0)
            {
                cnt--;
                max += cnt;
            }

            return max;
        }


    }
}