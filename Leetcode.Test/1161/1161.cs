namespace Leetcode.Test
{
    public class _1161
    {
        public int MaxLevelSum(TreeNode root)
        {
            int lvl = 0;
            int sum = root.val;
            var _q = new Queue<(TreeNode node, int level)>();

            (int level, int sum) res = (lvl, sum);
            _q.Enqueue((root, lvl));

            while(_q.Count > 0)
            {
                var node = _q.Dequeue();
                if (node.level == lvl)
                {
                    sum += node.node.val;
                }
                else
                {
                    if (sum > res.sum)
                    {
                        res.sum = sum;
                        res.level = lvl;
                    }
                    sum = node.node.val;
                    lvl = node.level;
                }

                if (node.node.left != null)
                    _q.Enqueue((node.node.left, lvl + 1));

                if (node.node.right != null)
                    _q.Enqueue((node.node.right, lvl + 1));
            }

            if (sum > res.sum)
            {
                res.sum = sum;
                res.level = lvl;
            }

            return res.level + 1;
        }

    }
}