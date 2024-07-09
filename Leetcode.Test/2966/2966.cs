namespace Leetcode.Test
{
    public class _2966
    {
        public int[][] DivideArray(int[] nums, int k)
        {
            Array.Sort(nums);

            List<int[]> result = new List<int[]>();
            for (int i = 0; i < nums.Length/3; i++)
            {
                var a = new int[3];
                for (int j = 0; j < 3; j++)
                {
                    a[j] = nums[i * 3 + j];
                }

                if (a[2] - a[0] <= k)
                    result.Add(a);
                else
                    return new int[0][];
            }

            return result.ToArray();
        }

    }
}