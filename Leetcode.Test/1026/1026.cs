namespace Leetcode.Test
{
    public class _1026
    {
        public int MaxAncestorDiff(TreeNode root)
        {
            return dfs(root, root.val, root.val);
        }

        int dfs(TreeNode root, int min, int max)
        {
            var currentDelta = Math.Max(Math.Abs(max - root.val), Math.Abs(min - root.val));

            if (root.val < min) { min = root.val; }
            if (root.val > max) { max = root.val; }

            if (root.left != null)
            {
                var leftDelta = dfs(root.left, min, max);
                if (leftDelta > currentDelta)
                    currentDelta = leftDelta;
            }

            if (root.right != null)
            {
                var rightDelta = dfs(root.right, min, max);
                if (rightDelta > currentDelta)
                    currentDelta = rightDelta;
            }
            return currentDelta;
        }
    }
}