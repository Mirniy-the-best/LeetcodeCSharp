namespace Leetcode.Test
{
    public class _1372
    {
        enum direction { right, left}
        public int LongestZigZag(TreeNode root)
        {
            return Math.Max(
                dfs(root.right, direction.left, 0),
                dfs(root.left, direction.right, 0));
        }

        int dfs(TreeNode root, direction direction, int cnt)
        {
            if (root == null) return cnt;

            int left = dfs(root.left, direction.right, direction == direction.left ? cnt + 1 : 0);
            int right = dfs(root.right, direction.left, direction == direction.left ? 0 : cnt + 1);

            return Math.Max(left, right);
        }
    }
}