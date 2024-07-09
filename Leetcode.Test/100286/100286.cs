namespace Leetcode.Test
{
    public class _100286
    {
        public bool CanMakeSquare(char[][] grid)
        {

            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < 2; j++)
                {
                    int w = 0;
                    int b = 0;

                    if (grid[i][j] == 'B') b++;
                    if (grid[i+1][j] == 'B') b++;
                    if (grid[i+1][j+1] == 'B') b++;
                    if (grid[i][j+1] == 'B') b++;

                    if (grid[i][j] == 'W') w++;
                    if (grid[i + 1][j] == 'W') w++;
                    if (grid[i + 1][j + 1] == 'W') w++;
                    if (grid[i][j + 1] == 'W') w++;

                    if (w >= 3 || b >= 3) return true;
                }
            }

            return false;
        }


    }
}