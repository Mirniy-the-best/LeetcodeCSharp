namespace Leetcode.Test
{
    public class _2824
    {
        public int CountPairs(IList<int> nums, int target)
        {
            nums = nums.Order().ToList();

            int cnt = 0;
            for (int i = nums.Count() - 1; i > 0; i--)
                cnt += search(nums, target - nums[i], i-1);

            return cnt;
        }

        int search(IList<int> nums, int target, int r)
        {
            var rlimit = r;
            int l = 0;
            while (l <= r)
            {
                int m = (r - l) / 2 + l;

                if (nums[m] == target) { r = m - 1; continue; }
                if (nums[m] > target) { r = m - 1; continue; }

                if (nums[m] < target)
                {
                    if (m == rlimit || nums[m + 1] >= target)
                        return m + 1;
                    l = m + 1;
                }

            }
            return 0;
        }


    }
}