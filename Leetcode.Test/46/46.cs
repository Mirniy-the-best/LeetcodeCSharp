namespace Leetcode.Test
{
    public class _46
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var res = new List<IList<int>>();

            if (nums.Length == 1)
            {
                res.Add(new List<int>() { nums[0] });
                return res;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                var tmp = nums.Where(x=>x != nums[i]).ToArray();
                var tres = Permute(tmp);
                foreach (var lst in tres)
                {
                    lst.Add(nums[i]);
                    res.Add(lst);
                }
            }

            return res;
        }


    }
}