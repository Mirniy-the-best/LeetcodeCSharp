namespace Leetcode.Test
{
    public class _645
    {
        public int[] FindErrorNums(int[] nums)
        {
            int[] index = new int[10001];
            int n1 = -1;
            int n2 = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                index[nums[i]]++;
                if (index[nums[i]] > 1) n1 = nums[i];
            }
            for (int i = 1; i <= nums.Length; i++)
                if (index[i] == 0)
                {
                    n2 = i;
                    break;
                }

            return new[] { n1, n2 };
        }

    }
}