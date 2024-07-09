namespace Leetcode.Test
{
    public class _100302
    {
        public int MaxPointsInsideSquare(int[][] points, string s)
        {
            var map = new Dictionary<int, List<char>>();

            for (int i = 0; i < s.Length; i++)
            {
                var val = Math.Max(Math.Abs(points[i][0]), Math.Abs(points[i][1]));
                if (!map.ContainsKey(val))
                    map.Add(val, new List<char>() { s[i] });
                else
                    map[val].Add(s[i]);
            }

            var rc = map.OrderBy(x => x.Key).ToArray();
            int cnt = 0;
            var set = new HashSet<char>();
            for (int i = 0; i < rc.Length; i++)
            {
                var c = set.Count;
                if (rc[i].Value.Distinct().Count() == rc[i].Value.Count()
                    && !set.Intersect(rc[i].Value).Any())
                {
                    cnt += rc[i].Value.Count();
                    set.UnionWith(rc[i].Value);
                }
                else
                    break;
            }
            return cnt;
        }


    }
}