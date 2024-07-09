namespace Leetcode.Test
{
    public class _199
    {
        public IList<int> RightSideView(TreeNode root)
        {
            var result = new List<int>();
            if (root == null) return result;

            var _q = new Queue<TreeNode>();
            _q.Enqueue(root);

            while (_q.Count > 0) {
                var levelcnt = _q.Count;
                result.Add(_q.Peek().val);
                for (int i = 0; i < levelcnt; i++)
                {
                    var node = _q.Dequeue();
                    if (node.right != null)
                        _q.Enqueue(node.right);
                    if(node.left != null)
                        _q.Enqueue(node.left);
                }
            }

            return result;
        }

    }
}