namespace Leetcode.Test
{
    public class _931
    {
        public int MinFallingPathSum(int[][] matrix)
        {
            var index = new int[matrix.Length][];
            index[0] = matrix[0];

            for ( var i = 0; i < matrix.Length; i++ )
                index[0][i] = matrix[0][i];

            for (var i = 1; i < matrix.Length; i++)
            {
                index[i] = new int[matrix.Length];
                for (var j = 1; j < matrix.Length - 1; j++)
                {
                    index[i][j] = Math.Min(Math.Min(index[i - 1][j], index[i - 1][j - 1]), index[i - 1][j + 1])
                        + matrix[i][j];
                }
                index[i][0] = Math.Min(index[i - 1][0], index[i - 1][1]) + matrix[i][0];
                index[i][matrix.Length-1] = Math.Min(index[i - 1][matrix.Length - 1], index[i - 1][matrix.Length - 2]) + matrix[i][matrix.Length-1];
            }
            return index.Last().Min();
        }

    }
}