namespace Leetcode.Test
{
    public class _2597
    {
        public int BeautifulSubsets(int[] nums, int k)
        {
            var res = dfs(nums, k, 0, new List<int>(), 0);
            return res;
        }

        int dfs(int[] nums, int k, int p, List<int> tail, int res) {
            if(p== nums.Length) return res;

            for(int i = p; i < nums.Length; i++)
            {
                if (!tail.Contains(nums[i] - k) && !tail.Contains(nums[i] + k)) {
                    res++;
                    res = dfs(nums, k, i + 1, tail.Append(nums[i]).ToList(), res );
                }
            }
            return res;
        }
    }
}