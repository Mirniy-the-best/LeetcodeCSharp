namespace Leetcode.Test
{
    public class _1679
    {
        public int MaxOperations(int[] nums, int k)
        {
            int l = 0;
            int r = nums.Length - 1;
            int sum = 0;

            nums = nums.Order().ToArray();
            while (l < r)
            {
                var current = nums[l] + nums[r];
                if (current == k)
                {
                    sum++;
                    l++;
                    r--;
                    continue;
                }
                if (current > k) r--;
                else l++;
            }
            return sum;
        }

    }
}