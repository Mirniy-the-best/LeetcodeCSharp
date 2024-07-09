using Microsoft.VisualStudio.TestPlatform.ObjectModel.Engine.TesthostProtocol;
using System.Diagnostics.CodeAnalysis;

namespace Leetcode.Test
{
    public class _2542
    {
        public long MaxScore(int[] nums1, int[] nums2, int k)
        {
            var _set = new PriorityQueue<KeyValuePair<int, int>, int>();
            for (int i = 0; i < nums1.Length; i++)
                _set.Enqueue(new KeyValuePair<int, int>(nums1[i], nums2[i]), -nums2[i]);

            long max = 0;
            var q = new PriorityQueue<int, int>();
            long sum = 0;
            for (int i = 0; i < k-1 && _set.Count > 0; i++)
            {
                var item = _set.Dequeue();
                q.Enqueue(item.Key, item.Key);
                sum += item.Key;
            }
            var titem = _set.Dequeue();
            sum += titem.Key;
            q.Enqueue(titem.Key, titem.Key);
            max = sum * titem.Value;

            while(_set.Count > 0)
            {
                var nextItem = _set.Dequeue();
                sum = sum - q.Dequeue() + nextItem.Key;
                max = Math.Max(max, sum * nextItem.Value);
                q.Enqueue(nextItem.Key, nextItem.Key);
            }

            return max;
        }

        class intComparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                int r = x.CompareTo(y);
                if (r == 0)
                    return 1;
                return r;
            }
        }
    }
}