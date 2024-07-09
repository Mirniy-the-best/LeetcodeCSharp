namespace Leetcode.Test
{
    public class _198
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            if (nums.Length == 2) return Math.Max(nums[0], nums[1]);

            var res = new int[nums.Length];
            res[0] = nums[0];
            res[1] = nums[1];
            res[2] = nums[2] + res[0];
            for (int i = 3; i < nums.Length; i++)
            {
                res[i] = nums[i] + Math.Max(res[i - 3], res[i - 2]);
            }

            return Math.Max(res[nums.Length-1], res[nums.Length - 2]);
        }

    }
}