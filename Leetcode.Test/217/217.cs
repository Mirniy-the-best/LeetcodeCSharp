namespace Leetcode.Test
{
    public class _217
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var set = new HashSet<int>();

            foreach (int num in nums)
            {
                if(set.Contains(num))
                    return true;

                set.Add(num);
            }
            return false;
        }


    }
}