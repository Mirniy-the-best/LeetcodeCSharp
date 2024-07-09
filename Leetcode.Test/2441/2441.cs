namespace Leetcode.Test
{
    public class _2441
    {
        public int FindMaxK(int[] nums)
        {
            var negatives = nums.Where(x => x < 0);
            var positives = nums.Where(x => x > 0);
            var result = positives
                .GroupJoin(negatives,
                    p => p,
                    n => -n,
                    (p, n) => new { p, n })
                .Where(x => x.n.Any())
                .DefaultIfEmpty(new { p = -1, n = Enumerable.Empty<int>() })
                .Max(x => x.p);

            return result;
        }


    }
}