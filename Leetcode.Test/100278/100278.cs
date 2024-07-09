
namespace Leetcode.Test
{
    public class _100278
    {
        public long NumberOfRightTriangles(int[][] grid)
        {
            long cnt = 0;

            long[] rows = new long[grid.Length];
            long[] cols = new long[grid[0].Length];

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        rows[i]++;
                        cols[j]++;
                    }
                }
            }

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1 && rows[i] > 0 && cols[j] > 0)
                    {
                        cnt += (rows[i] - 1) * (cols[j] - 1);
                    }
                }
            }

            return cnt;
        }

        private long IsTriangle(int[][] grid, int si, int sj)
        {
            long rr = 0;
            long rc = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                if (grid[i][sj] == 1 && i != si)
                    rr++;
            }

            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[si][j] == 1 && j!=sj)
                    rc++;
            }

            if (rr == 0 || rc == 0) return 0;
            return rr*rc;
        }
    }
}