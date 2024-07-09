namespace Leetcode.Test
{
    public class _1493
    {
        public int LongestSubarray(int[] nums)
        {
            int l = 0;
            int currentLen = 0;
            int max = 0;
            bool isZeroExist = false;

            for (int r = 0; r < nums.Length; r++)
            {
                if (nums[r] == 0) {
                    if (!isZeroExist) {
                        isZeroExist = true;
                    }
                    else {
                        int nextLeft = nums[l] == 0 ? 1 : 0;
                        do
                        {
                            l++;
                            if(nextLeft == 0)
                                currentLen = Math.Max(currentLen - 1, 0);
                        } while (l < r && nums[l] != nextLeft);
                        if (nextLeft == 0)
                            l++;
                    }
                }
                else {
                    currentLen++;
                    if(currentLen > max) max = currentLen;
                }
            }

            if (!isZeroExist) max--;
            return max;
        }

    }
}