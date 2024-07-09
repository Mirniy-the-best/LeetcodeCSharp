namespace Leetcode.Test
{
    public class _265
    {
        public int MissingNumber(int[] nums)
        {
            int mask = nums.Length;
            var val = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                mask += i;
                val += nums[i];
            }
            return mask - val;
        }


    }
}