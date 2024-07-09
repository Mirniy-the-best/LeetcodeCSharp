namespace Leetcode.Test
{
    public class _979
    {

        int summ = 0;
        public int DistributeCoins(TreeNode root)
        {
            dfs(root);
            return summ;
        }

        int dfs(TreeNode root)
        {
            if(root == null) return 0;

            int val = root.val + dfs(root.left) + dfs(root.right)-1;
            summ += Math.Abs(val);
            return val;
        }

    }
}