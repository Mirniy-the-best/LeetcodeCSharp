namespace Leetcode.Test
{
    public class _238
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            var res = new int[nums.Length];
            res[0] = 1;

            for (int i = 1; i < nums.Length; i++)
                res[i] = res[i-1] * nums[i-1];

            var previous = 1;
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                previous*= nums[i+1];
                res[i] *= previous;
            }

            return res;
        }

    }
}