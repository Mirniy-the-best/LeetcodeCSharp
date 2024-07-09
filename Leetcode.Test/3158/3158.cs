namespace Leetcode.Test
{
    public class _3158
    {
        public int DuplicateNumbersXOR(int[] nums)
        {
            var res = 0;
            foreach (var num in nums.Distinct())
            {
                if (nums.Count(x => x == num) > 1)
                    res ^= num;
            }
            return res;
        }


    }
}