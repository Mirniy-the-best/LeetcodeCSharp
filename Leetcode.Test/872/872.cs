using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _872
    {
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            var l1 = GetLeafs(root1, new List<int>());
            var l2 = GetLeafs(root2, new List<int>());
            return Enumerable.SequenceEqual(l1, l2);
        }

        List<int> GetLeafs(TreeNode root, List<int> values)
        {
            if(root.left == null && root.right == null)
            {
                values.Add(root.val);
                return values;
            }
            if(root.left!=null)  values = GetLeafs(root.left, values);
            if(root.right!=null) values = GetLeafs(root.right, values);
            return values;
        }

    }
}