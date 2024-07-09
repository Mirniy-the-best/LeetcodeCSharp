namespace Leetcode.Test
{
    public class _350
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length) return Intersect(nums2, nums1);

            var ind1 = new Dictionary<int, int>();
            foreach (int i in nums1)
                ind1[i] = ind1.GetValueOrDefault(i) + 1;

            var ind2 = new Dictionary<int, int>();
            foreach (int i in nums2)
                ind2[i] = ind2.GetValueOrDefault(i) + 1;

            foreach (var i in ind1)
                ind1[i.Key] = Math.Min(ind2.GetValueOrDefault(i.Key), i.Value);

            return ind1
                .SelectMany(x => Enumerable.Repeat(x.Key, x.Value))
                .ToArray();
        }


    }
}