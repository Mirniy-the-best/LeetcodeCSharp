using System.Text;

namespace Leetcode.Test
{
    public class _257
    {
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            return dfs(root, "");
        }

        IList<string> dfs(TreeNode root, string path)
        {
            if(path.Length != 0)
                path += $"->";
            path += root.val.ToString();

            if (root.left == null && root.right == null)
                return new List<string> { path };

            var list = new List<string>();
            if (root.left != null)
                list.AddRange(dfs(root.left, path));
            if (root.right != null)
                list.AddRange(dfs(root.right, path));
            return list;
        }
    }
}