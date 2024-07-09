namespace Leetcode.Test
{
    public class _100303
    {
        public int[] OccurrencesOfElement(int[] nums, int[] queries, int x)
        {
            var set = new List<int>();

            for (int i = 0; i < nums.Length; i++)
                if (nums[i] == x) set.Add(i);

            int[] res = new int[queries.Length];
            for (int i = 0;i < queries.Length;i++)
            {
                if (queries[i] > set.Count)
                    res[i] = -1;
                else
                    res[i] = set[queries[i] - 1];
            }

            return res;
        }


    }
}