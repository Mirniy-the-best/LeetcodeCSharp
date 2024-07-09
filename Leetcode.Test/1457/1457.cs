namespace Leetcode.Test
{
    public class _1457
    {
        public int PseudoPalindromicPaths(TreeNode root)
        {
            return dfs(root, new HashSet<int>());
        }

        int dfs(TreeNode root, HashSet<int> index)
        {
            if (!index.Remove(root.val))
                index.Add(root.val);

            if (root.left == null && root.right == null)
            {
                var result = index.Count < 2 ? 1 : 0;
                return result;
            }

            int res = 0;
            if (root.left != null)
                res += dfs(root.left, new HashSet<int>(index));

            if (root.right != null)
                res += dfs(root.right, new HashSet<int>(index));
            return res;
        }

    }
}