namespace Leetcode.Test
{
    public class _1365
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
           var set = nums
                .Select((x, i) => new KeyValuePair<int,int>(x, i))
                .OrderBy (x => x.Key)
                .ToArray();

            var r = new int[nums.Length];
            int v = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && set[i].Key != set[i - 1].Key)
                    v=i;

                r[set[i].Value] = v;
            }

            return r;
        }


    }
}