using System.Globalization;

namespace Leetcode.Test
{
    public class _912
    {
        public int[] SortArray(int[] nums)
        {
            if (nums.Length <= 1) return nums;

            int mid = (nums.Length + 1) / 2;
            int[] num1 = new int[mid];
            Array.Copy(nums, num1, mid);

            int[] num2 = new int[nums.Length - mid];
            Array.Copy(nums.Skip(mid).ToArray(), num2, nums.Length - mid);

            return Merge(SortArray(num1), SortArray(num2));
        }

        private int[] Merge(int[] ints1, int[] ints2)
        {
            var res = new List<int>(ints1.Length + ints2.Length);

            int i = 0, j = 0;
            for (; i < ints1.Length && j < ints2.Length;)
                if (ints1[i] <= ints2[j])
                    res.Add(ints1[i++]);
                else
                    res.Add(ints2[j++]);

            while (i < ints1.Length)
                res.Add(ints1[i++]);

            while (j < ints2.Length)
                res.Add(ints2[j++]);

            return res.ToArray();
        }
    }
}