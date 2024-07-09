namespace Leetcode.Test
{
    public class _700
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            return dfs(root, val);
        }
        TreeNode dfs(TreeNode root, int val)
        {
            if (root == null) return null;
            if( root.val == val) return root;
            if (root.val < val) return dfs(root.right, val);
            else return dfs(root.left, val);
        }
    }
}