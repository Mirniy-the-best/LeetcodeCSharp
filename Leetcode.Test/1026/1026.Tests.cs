namespace Leetcode.Test
{
    [TestFixture]
    public class _1026_Tests
    {
        TreeNode InitTree(int?[] nums)
        {
            if (nums.Length == 0) return null;

            var root = new TreeNode(nums[0].Value);
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            for (int i = 1; i < nums.Length; i++)
            {
                var node = queue.Dequeue();
                if (nums[i] != null)
                {
                    node.left = new TreeNode(nums[i].Value);
                    queue.Enqueue(node.left);
                }

                if (++i < nums.Length && nums[i] != null)
                {
                    node.right = new TreeNode(nums[i].Value);
                    queue.Enqueue(node.right);
                }
            }
            return root;
        }

        [Test]
        public void Test2()
        {
            var root = InitTree([1, null, 2, null, 0, 3]);
            var expected = 3;
            var actual = new _1026().MaxAncestorDiff(root);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test1()
        {
            var root = InitTree([8, 3, 10, 1, 6, null, 14, null, null, 4, 7, 13]);
            var expected = 7;
            var actual = new _1026().MaxAncestorDiff(root);
            Assert.AreEqual(expected, actual);
        }

    }
}
