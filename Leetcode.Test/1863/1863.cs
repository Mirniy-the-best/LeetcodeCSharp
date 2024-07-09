namespace Leetcode.Test
{
    public class _1863
    {
        public int SubsetXORSum(int[] nums, int pos = 0, int xor = 0)
        {
            if(pos == nums.Length) return xor;

            var with = SubsetXORSum(nums, pos+1, xor ^ nums[pos]);
            var without = SubsetXORSum(nums, pos + 1, xor);
            return with+without;
        }


    }
}