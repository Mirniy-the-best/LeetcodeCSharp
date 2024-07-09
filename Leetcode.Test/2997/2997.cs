namespace Leetcode.Test
{
    public class _2997
    {
        public int MinOperations(int[] nums, int k)
        {
            var n = nums.Aggregate((x,num) => x ^ num) ^ k;
            return int.PopCount(n);
        }

    }
}