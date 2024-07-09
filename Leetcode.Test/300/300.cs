namespace Leetcode.Test
{
    public class _300
    {
        public int LengthOfLIS(int[] nums)
        {
            if (nums.Length == 1) return 1;
            var buf = new List<int>() { nums[0] };

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == buf.Last()) continue;
                if (nums[i] > buf.Last()) { buf.Add(nums[i]); continue; }

                int l = 0; int r = buf.Count -1, m = 0;
                while (l <= r)
                {
                    m = l + (r - l) / 2;
                    if (buf[m] == nums[i]) break;
                    if (buf[m] < nums[i]) l = m + 1;
                    else r = m - 1;
                }
                if (buf[m] != nums[i])
                    buf[l] = nums[i];
            }

            return buf.Count();
        }
    }
}