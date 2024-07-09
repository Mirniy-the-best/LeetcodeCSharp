namespace Leetcode.Test
{
    public class _1448
    {
        public int GoodNodes(TreeNode root)
        {
            return dfs(root, root.val);
        }

        int dfs(TreeNode root, int max)
        {
            var cnt = 0;
            if (root.val >= max)
            {
                max = root.val;
                cnt++;
            }

            if (root.left != null)
                cnt += dfs(root.left, max);
            if (root.right != null)
                cnt += dfs(root.right, max);

            return cnt;
        }

    }
}