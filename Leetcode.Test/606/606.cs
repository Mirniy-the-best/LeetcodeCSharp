using System.Text;

namespace Leetcode.Test
{
    public class _606
    {
        public string Tree2str(TreeNode root)
        {
            var res = new StringBuilder($"{root.val}");

            if (root.left != null || root.right != null)
                res = foo(root.left, res);

            if (root.right != null)
                res = foo(root.right, res);
            return res.ToString();
        }

        StringBuilder foo(TreeNode root, StringBuilder res)
        {
            res.Append('(');
            if (root != null)
            {
                res.Append(root.val);
                if (root.left != null || root.right != null)
                    res = foo(root.left, res);
                if (root.right != null)
                    res = foo(root.right, res);
            }
            res.Append(')');
            return res;
        }

    }
}