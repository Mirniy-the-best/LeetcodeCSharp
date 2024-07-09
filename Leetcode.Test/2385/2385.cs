
namespace Leetcode.Test
{
    public class _2385
    {

        int max = 0;
        public int AmountOfTime(TreeNode root, int start)
        {
            dfs(root, start);
            return max;
        }

        int dfs(TreeNode root, int goal)
        {
            if (root == null) return 0;
            if (root.val == goal)
            {
                var mc = Math.Max(dfs(root.left, goal), dfs(root.right, goal));
                if (mc > max) max = mc;
                return -1;
            }
            var left = dfs(root.left, goal);
            var right = dfs(root.right, goal);
            if (left >= 0 && right >= 0)
                return Math.Max(left, right) + 1;

            var distance = Math.Abs(left) + Math.Abs(right);
            if (distance > max) max = distance;
            return Math.Min(left, right) - 1;
        }
    }
}