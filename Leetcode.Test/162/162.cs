namespace Leetcode.Test
{
    public class _162
    {
        public int FindPeakElement(int[] nums)
        {
            if (nums.Length == 1) return 0;

            return Search(nums, 0, nums.Length - 1);
        }

        int Search(int[] nums, int l, int r)
        {
            while (l <= r)
            {
                var m = l + (r - l) / 2;
                if (m == 0)
                    if (nums[m] > nums[m + 1])
                        return m;
                    else
                        l = m + 1;

                if (m == nums.Length - 1)
                    if (nums[m] > nums[m - 1])
                        return m;
                    else
                        r = m - 1;

                if (m > 0 && m < nums.Length - 1)
                {
                    if (nums[m - 1] < nums[m] && nums[m + 1] < nums[m])
                        return m;

                    if (nums[m] < nums[m + 1])
                    {
                        var res = Search(nums, m + 1, r);
                        if (res >= 0) return res;
                    }

                    if (nums[m] < nums[m - 1])
                    {
                        var res = Search(nums, l, m - 1);
                        if (res >= 0) return res;
                    }
                }
            }
            return -1;
        }

    }
}