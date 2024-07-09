using System.Collections;

namespace Leetcode.Test
{
    public class _2352
    {
        public int EqualPairs(int[][] grid)
        {
            var rows = new Dictionary<int, int>();
            var columns = new Dictionary<int, int>();
            var intersect = new HashSet<int>();

            for (int i = 0; i < grid.Length; i++)
            {
                var rhash = 0;
                var chash = 0;
                for (var j = 0; j < grid.Length; j++)
                {
                    rhash = HashCode.Combine(rhash, grid[i][j]);
                    chash = HashCode.Combine(chash, grid[j][i]);
                }

                rows[rhash] = rows.GetValueOrDefault(rhash)+1;
                columns[chash] = columns.GetValueOrDefault(chash)+1;

                if(columns.ContainsKey(rhash))
                    intersect.Add(rhash);

                if(rows.ContainsKey(chash))
                    intersect.Add(chash);
            }
            return intersect.Sum(x => columns[x] * rows[x]);
        }

    }
}