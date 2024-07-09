namespace Leetcode.Test
{
    public class _75
    {
        public void SortColors(int[] nums)
        {
            var l = 0;
            for (; l < nums.Length && nums[l] == 0; l++);

            var r = nums.Length-1;
            for (; r > l && nums[r] == 2; r--);

            for (var i = l; i <= r; )
            {
                if (nums[i] == 2)
                {
                    (nums[i], nums[r]) = (nums[r], nums[i]);
                    r--;
                    continue;
                }

                if (nums[i] == 0)
                {
                    (nums[i], nums[l]) = (nums[l], nums[i]);
                    l++;
                }
                i++;
            }
        }


    }
}