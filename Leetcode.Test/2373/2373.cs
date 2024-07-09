namespace Leetcode.Test
{
    public class _2373
    {
        public int[][] LargestLocal(int[][] grid)
        {
            int n = grid.Length;
            var result = new int[n-2][];

            for (int i = 0; i < n - 2; i++)
            {
                result[i] = new int[n-2];
                for (int j = 0; j < n - 2; j++)
                {
                    result[i][j] = new[] { grid[i][j],
                        grid[i + 1][j],
                        grid[i + 2][j],
                        grid[i + 1][j + 1],
                        grid[i + 1][j + 2],
                        grid[i + 2][j + 1],
                        grid[i + 2][j + 2],
                        grid[i][j + 1],
                        grid[i][j + 2],
                    }.Max();
                }
            }

            return result;
        }


    }
}