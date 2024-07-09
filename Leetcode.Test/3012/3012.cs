namespace Leetcode.Test
{
    public class _3012
    {
        public int MinimumArrayLength(int[] nums)
        {
            int min = nums.Min();
            int mincnt = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == min)
                    mincnt++;
                else
                    if (nums[i] % min != 0)
                        return 1;
            }
            return (int)Math.Ceiling(mincnt / 2.0);
        }

    }
}