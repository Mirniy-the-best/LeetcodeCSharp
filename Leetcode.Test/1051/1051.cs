namespace Leetcode.Test
{
    public class _1051
    {
        public int HeightChecker(int[] heights)
        {
            var expected = heights.Order().ToArray();
            int cnt = 0;
            for (int i = 0; i < heights.Length; i++)
                if (heights[i] != expected[i])
                    cnt++;

            return cnt;
        }


    }
}