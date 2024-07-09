namespace Leetcode.Test
{
    public class _1512
    {
        public int NumIdenticalPairs(int[] nums)
        {
            int res = 0;
            var set = new int[101];
            foreach ( var num in nums )
            {
                res += set[num];
                set[num]++;
            }

            return res;
        }


    }
}