namespace Leetcode.Test
{
    public class _1004
    {
        public int LongestOnes(int[] nums, int k)
        {
            int start = 0;
            var z = new Queue<int>();
            int max = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    z.Enqueue(i);

                if (z.Count > k)
                {
                    max = Math.Max(max, i - start);
                    start = z.Dequeue() + 1;
                }
            }

            max = Math.Max(max, nums.Length - start);
            return max;
        }
    }
}