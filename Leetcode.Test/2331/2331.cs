namespace Leetcode.Test
{
    public class _2331
    {
        public bool EvaluateTree(TreeNode root)
        {
            if (root.val == 0) return false;
            if (root.val == 1) return true;

            if (root.val == 2) return EvaluateTree(root.left) || EvaluateTree(root.right);
            return EvaluateTree(root.left) && EvaluateTree(root.right);
        }


    }
}