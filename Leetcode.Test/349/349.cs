namespace Leetcode.Test
{
    public class _349
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length) return Intersection(nums2, nums1);

            Array.Sort(nums2);

            var res = new HashSet<int>();

            for (int i = 0; i < nums1.Length; i++)
                if (search(nums2, nums1[i]))
                    res.Add(nums1[i]);

            return res.ToArray();
        }

        bool search(int[] nums, int val)
        {
            int l = 0;
            int r = nums.Length-1;

            while (l <= r)
            {
                int m = (r - l) / 2 + l;

                if (nums[m] == val)
                    return true;
                if (nums[m] < val)
                {
                    l = m + 1;
                    continue;
                }

                if (nums[m] > val)
                    r = m - 1;
            }

            return false;
        }
    }
}