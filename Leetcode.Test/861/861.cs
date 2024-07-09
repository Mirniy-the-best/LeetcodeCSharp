namespace Leetcode.Test
{
    public class _861
    {
        public int MatrixScore(int[][] grid)
        {
            int n = grid.Length;
            int m = grid[0].Length;

            var rows = new int[grid.Length];
            var cols = new int[grid[0].Length];

            for (int i = 0; i < n; i++) {
                if (grid[i][0] == 0)
                    for (int j = 0; j < m; j++)
                        grid[i][j] = grid[i][j] == 1 ? 0 : 1;
            }

            for (int j = 1; j < m; j++)
            {
                int p = 0;
                for (int i = 0; i < n; i++)
                    p += grid[i][j];

                if (p < (n+1) / 2)
                    for (int i = 0; i < n; i++)
                        grid[i][j] = grid[i][j] == 1 ? 0 : 1;
            }

            int summ = 0;
            for (int i = 0; i < n; i++)
            {
                var s = (int)Math.Pow(2, m-1);
                for (int j = 1; j < m; j++)
                {
                    if (grid[i][j] == 1)
                        s += (int)Math.Pow(2, m - j - 1);
                }
                summ += s;
            }
            return summ;
        }


    }
}