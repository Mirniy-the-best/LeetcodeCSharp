namespace Leetcode.Test
{
    public class _66
    {
        public int[] PlusOne(int[] digits)
        {
            var res = new List<int>(digits.Length+1);
            int extra = 1;

            for (int i = digits.Length-1; i >= 0; i--)
            {
                int num = digits[i]+extra;
                if(num > 9)
                    extra = 1;
                else
                    extra = 0;
                res.Add(num % 10);
            }

            if (extra > 0)
                res.Add(extra);

            return reverse(res.ToArray());
        }

        private int[] reverse(int[] digits)
        {
            int l = 0; int r = digits.Length-1;

            while (l < r)
            {
                var b = digits[l];
                digits[l] = digits[r];
                digits[r] = b;
                l++;
                r--;
            }
            return digits;
        }
    }
}