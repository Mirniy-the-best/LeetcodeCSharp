namespace Leetcode.Test
{
    public class _260
    {
        public int[] SingleNumber(int[] nums)
        {
            var xor = nums.Aggregate((a, b) => a ^ b);

            int shift = 1;
            while ((xor & shift) != shift)
            {
                shift <<= 1;
            };

            var res = new int[2];
            foreach (var x in nums)
            {
                if((x&shift) == shift)
                    res[0]^= x;
                else
                    res[1]^= x;
            }

            return res;
        }


    }
}