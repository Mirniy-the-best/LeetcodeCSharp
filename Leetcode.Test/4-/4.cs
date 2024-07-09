using System.Security.Cryptography;

namespace Leetcode.Test
{
    public class _4
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums2.Length < nums1.Length) { return FindMedianSortedArrays(nums2, nums1); }
            var n = (nums1.Length + nums2.Length) / 2;

            var i = search(nums1, nums2, n);
            int rc;
            if (i <= nums1.Length)
                rc = nums2[n - i];
            else
                rc = nums1[i];

            return rc;

        }

        private int search(int[] nums1, int[] nums2, int n)
        {
            if (nums1.Last() <= nums2.First()) return nums1.Length;
            if (nums2.Last() <= nums1.First()) return 0;

            int l = 0; int r = nums1.Length;
            while (l <= r)
            {
                var i1 = (r - l) / 2 + l;
                var i2 = n - i1;
                //if (i1 == 0 || i1 == nums1.Length) return i1;

                if (nums1[i1-1] > nums2[i2])
                {
                    l = i1;
                    continue;
                }
                if (nums1[i1] < nums2[i2 -1])
                {
                    r = i1;
                    continue;
                }
                return i1;
            }

            return r;
        }
    }
}