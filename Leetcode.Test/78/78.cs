using System.Linq;

namespace Leetcode.Test
{
    public class _78
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            var res = new List<IList<int>>() { new List<int>()};

            return Sub(nums, 0, res);
        }

        public IList<IList<int>> Sub(int[] nums, int index, IList<IList<int>> lst)
        {
            if (index == nums.Length) return lst;

            int len = lst.Count;
            for (int i = 0; i < len; i++)
            {
                var tmp = lst[i].ToList();
                tmp.Add(nums[index]);
                lst.Add(tmp);
            }

            return Sub(nums, index+1, lst);
        }


    }
}