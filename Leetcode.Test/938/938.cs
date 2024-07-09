
namespace Leetcode.Test
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class _938
    {
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            var sum = 0;
            if (root.val >= low && root.val <= high)
            {
                sum += root.val;
                if (root.left != null) sum += RangeSumBST(root.left, low, high);
                if (root.right != null) sum += RangeSumBST(root.right, low, high);
                return sum;
            }
            if (root.val <= low && root.right != null)
            {
                sum += RangeSumBST(root.right, low, high);
                return sum;
            }
            if (root.val >= high && root.left != null)
            {
                sum += RangeSumBST(root.left, low, high);
                return sum;
            }
            return sum;
        }

    }
}