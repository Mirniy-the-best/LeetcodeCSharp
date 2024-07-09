namespace Leetcode.Test
{
    public class _100331
    {
        public int MaximumLength(int[] nums, int k)
        {
            if (nums.Length == 1) return 1;

            var ind = new List<KeyValuePair<int, int>>();
            var cnts = new Dictionary<int, int>();

            int cnt = 0;
            int num = nums[0];
            //cnts[num] = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                cnts[nums[i]] = cnts.GetValueOrDefault(nums[i]) + 1;

                if (nums[i] == num)
                    cnt++;
                else
                {
                    ind.Add(new KeyValuePair<int, int>(num, cnt));
                    cnt = 1;
                    num = nums[i];
                }

                if(i == nums.Length - 1)
                    ind.Add(new KeyValuePair<int, int>(num, cnt));
            }


            if (k>0)
                return ind.OrderByDescending(x => x.Value).Take(k + 1).Sum(x => x.Value);
            else
                return cnts.Max(x => x.Value);

        }


    }
}