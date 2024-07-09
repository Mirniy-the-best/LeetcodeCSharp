namespace Leetcode.Test
{
    public class _1219
    {
        public int GetMaximumGold(int[][] grid)
        {
            var sum = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for(int j = 0;  j < grid[i].Length; j++)
                {
                    if (grid[i][j] > 0)
                    {
                        var val = GetMaximumPath(grid, i, j);
                        if (val > sum) sum = val;
                    }
                }
            }
            return sum;
        }

        int GetMaximumPath(int[][] grid, int i, int j)
        {
            var sum = grid[i][j];
            var lst = new List<int>() {0};

            var a = grid;
            a[i][j] = 0;
            if (i > 0 && grid[i - 1][j] > 0)
                lst.Add(GetMaximumPath(a, i - 1, j));

            if (i < grid.Length-1 && grid[i + 1][j] > 0)
                lst.Add(GetMaximumPath(a, i + 1, j));

            if (j > 0 && grid[i][j - 1] > 0)
                lst.Add(GetMaximumPath(a, i, j - 1));

            if (j < grid[i].Length-1 && grid[i][j + 1] > 0)
                lst.Add(GetMaximumPath(a, i, j + 1));

            a[i][j] = sum;
            sum += lst.Max();
            return sum;
        }

    }
}