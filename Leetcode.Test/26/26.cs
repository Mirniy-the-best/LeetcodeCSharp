
namespace Leetcode.Test
{
    public class _26
    {
        public int RemoveDuplicates(int[] nums)
        {
            var l = 0;
            for(int i = 1; i<nums.Length; i++)
            {
                if (nums[i] > nums[l])
                {
                    l++;
                    nums[l] = nums[i];
                }
            }
            return l+1;
        }
    }
}