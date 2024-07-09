namespace Leetcode.Test
{
    public class _561
    {
        public int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);
            int summ = 0;
            for (int i = 0;i<nums.Length; i+=2)
                summ += nums[i];
            return summ;
        }


    }
}