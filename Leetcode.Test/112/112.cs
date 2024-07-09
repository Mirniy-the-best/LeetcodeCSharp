namespace Leetcode.Test
{
    public class _112
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null) return false;
            return dfs(root, targetSum, 0);
        }

        bool dfs(TreeNode root, int targetSum, int currentSum)
        {
            if(root == null) return false;

            currentSum += root.val;

            if(root.left == null && root.right == null)
                return targetSum == currentSum;

            return dfs(root.right, targetSum, currentSum)
                || dfs(root.left, targetSum, currentSum);
        }

    }
}