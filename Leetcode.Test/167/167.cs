
namespace Leetcode.Test
{
    public class _167
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int l = 0;
            int r = numbers.Length - 1;
            int s;
            do
            {
                s = numbers[l] + numbers[r];
                if (s > target) r--;
                if (s < target) l++;
            }
            while (s != target);
            return new[] { l + 1, r + 1 };
        }
    }
}