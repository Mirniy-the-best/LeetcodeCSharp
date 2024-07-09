namespace Leetcode.Test
{
    public class _236
    {
        TreeNode result;
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            dfs(root, p, q);
            return result;
        }

        int dfs(TreeNode root, TreeNode p, TreeNode q)
        {
            if(root == null) return 0;

            int cnt = dfs(root.left, p, q) + dfs(root.right, p, q);
            if (root == p || root == q)
                cnt++;

            if (cnt == 2 && result == null)
                result = root;

            return cnt;
        }

    }
}