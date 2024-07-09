namespace Leetcode.Test
{
    public class _1351
    {
        public int CountNegatives(int[][] grid)
        {
            var cnt = 0;
            int r = grid[0].Length;
            for (int i = 0; i < grid.Length; i++)
            {
                int val = serch(grid, i, r);
                cnt += val;
                r = grid[i].Length-val+1;
            }

            return cnt;
        }

        int serch(int[][] grid, int i, int r)
        {
            int l = 0;
            while (l <= r)
            {
                var m = (r - l) / 2 + l;

                if (grid[i][m] < 0 && m == 0)
                    return grid[i].Length;

                if (grid[i][m] >= 0 && (m == grid[i].Length-1 || grid[i][m + 1] < 0) )
                    return grid[i].Length - m - 1;

                if (grid[i][m] >= 0)
                {
                    l = m + 1;
                    continue;
                }

                if (grid[i][m] < 0)
                    r = m - 1;
            }
            return grid[i].Length - l - 1;
        }
    }
}