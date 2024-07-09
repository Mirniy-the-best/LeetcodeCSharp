namespace Leetcode.Test
{
    public class _334
    {
        public bool IncreasingTriplet(int[] nums)
        {
            int n = 3;
            int[] arr = new int[n];
            Array.Fill(arr, int.MaxValue);

            foreach (int num in nums)
            {
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] >= num)
                    {
                        if (i == n - 1) return true;

                        arr[i] = num;
                        break;
                    }
                }
            }
            return false;
        }


    }
}