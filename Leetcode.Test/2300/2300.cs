using System.Diagnostics.CodeAnalysis;

namespace Leetcode.Test
{
    public class _2300
    {
        public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
        {
            Array.Sort(potions);
            int[] res = new int[spells.Length];

            for (int i = 0; i < spells.Length; i++)
            {
                res[i] = potions.Length - Search(potions, spells[i], (ulong)success);
            }

            return res;
        }

        int Search(int[] nums, int spell, ulong target)
        {
            int l = 0; int r = nums.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;
                ulong current = (ulong)nums[m] * (ulong)spell;
                if (current == target && ( m == 0 || nums[m - 1] != nums[m])) { return m; }
                else if (current >= target) { r = m - 1; }
                else { l = m + 1; }
            }
            return l;
        }
    }
}