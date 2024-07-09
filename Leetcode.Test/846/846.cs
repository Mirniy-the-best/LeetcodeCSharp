namespace Leetcode.Test
{
    public class _846
    {
        public bool IsNStraightHand(int[] hand, int groupSize)
        {
            if (hand.Length % groupSize != 0) return false;

            var index = new SortedDictionary<int, int>();
            foreach (int i in hand)
                index[i] = index.GetValueOrDefault(i) + 1;

            while (index.Count > 0)
            {
                if (index.Count == 0) return false;
                var cur = index.First().Key;
                index[cur]--;
                if (index[cur] == 0) index.Remove(cur);

                for (int i = 1; i < groupSize; i++)
                {
                    if (index.Count == 0) return false;
                    cur++;
                    if (!index.ContainsKey(cur)) return false;
                    index[cur]--;
                    if (index[cur] == 0) index.Remove(cur);
                }
            }

            return true;
        }


    }
}