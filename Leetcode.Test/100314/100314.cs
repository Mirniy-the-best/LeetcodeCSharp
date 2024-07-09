namespace Leetcode.Test
{
    public class _100314
    {

        public IList<bool> GetResults(int[][] queries)
        {
            var result = new List<bool>();
            var blocks = new SortedList<int, int> { { 0, 0 } };

            foreach (var q in queries)
            {
                if (q[0] == 1)
                {
                    blocks.Add(q[1], q[1]);

                    var currentBlock = blocks.IndexOfKey(q[1]);
                    var prevBlockKey = blocks.Keys[currentBlock - 1];
                    var prevBlockVal = blocks.Values[currentBlock - 1];

                    var newGap = Math.Max(prevBlockVal, q[1] - prevBlockKey);
                    blocks.SetValueAtIndex(currentBlock, newGap);
 
                    for (var i = currentBlock + 1; i < blocks.Count; i++)
                    {
                        var newVal = Math.Max(blocks.Keys[i] - blocks.Keys[i - 1], blocks.Values[i - 1]);
                        if (newVal == blocks.Values[i]) break;
                        blocks.SetValueAtIndex(i, newVal);
                    }
                    continue;
                }

                if (q[2] > q[1])
                {
                    result.Add(false);
                    continue;
                }

                int target = search(blocks, q[1]);
                if (q[2] <= blocks.Values[target])
                {
                    result.Add(true);
                    continue;
                }

                result.Add(q[2] <= q[1] - blocks.Keys[target]);
            }
            return result;
        }

        int search(SortedList<int, int> src, int target)
        {
            int l = 0; int r = src.Count - 1;
            while (l <= r)
            {
                var m = (r - l) / 2 + l;
                if (src.Keys[m] == target) return m;
                if (src.Keys[m] > target)
                {
                    r = m - 1;
                    continue;
                }
                l = m + 1;
            }
            return r;
        }

    }
}