using System.ComponentModel.Design;

namespace Leetcode.Test
{
    public class _437
    {
        public int PathSum(TreeNode root, int targetSum)
        {
            return dfs(root, targetSum)
                + PathSum(root.left, targetSum)
                + PathSum(root.right, targetSum);
        }

        int dfs(TreeNode root, long target)
        {
            if (root == null) return 0;

            return (root.val == target ? 1 : 0)
                + dfs(root.left, target-root.val)
                + dfs(root.right, target-root.val);
        }
    }
}