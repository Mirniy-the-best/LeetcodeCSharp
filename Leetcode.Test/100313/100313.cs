namespace Leetcode.Test
{
    public class _100313
    {
        public int[] QueryResults(int limit, int[][] queries)
        {
            var balls = new Dictionary<int, int>();
            var cols = new Dictionary<int, HashSet<int>>();
            var res = new int[queries.Length];

            int cnt = 0;
            for (int i = 0; i < queries.Length; i++)
            {
                if (!balls.ContainsKey(queries[i][0]))
                {
                    balls.Add(queries[i][0], queries[i][1]);

                    var lst = cols.GetValueOrDefault(queries[i][1], new HashSet<int>());
                    lst.Add(queries[i][0]);
                    cols[queries[i][1]] = lst;
                }
                else
                {
                    int oldc = balls[queries[i][0]];
                    if (cols[oldc].Count==1)
                        cols.Remove(oldc);
                    else
                        cols[oldc].Remove(queries[i][0]);

                    var lst = cols.GetValueOrDefault(queries[i][1], new HashSet<int>());
                    lst.Add(queries[i][0]);
                    cols[queries[i][1]] = lst;

                    balls[queries[i][0]] = queries[i][1];
                }
                res[i] = cols.Count();
            }
            return res;
        }


    }
}