namespace Leetcode.Test
{
    public class _1608
    {
        public int SpecialArray(int[] nums)
        {
            var set = new int[1001];
            foreach (var x in nums)
                set[x]++;

            int sum = 0;
            for (int i = 1000; i>0; i--) {
                sum += set[i];
                if(sum == i)
                    return i;
            }
            return -1;
        }


    }
}