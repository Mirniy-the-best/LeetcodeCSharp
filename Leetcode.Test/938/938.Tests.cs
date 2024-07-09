

using System;

namespace Leetcode.Test
{
	[TestFixture]
	public class _938_Tests
	{
        private void FillTree(TreeNode root, Queue<int?> children)
        {
            var nodes = new Queue<TreeNode>();
            nodes.Enqueue(root);

            while (nodes.Any() && children.Any())
            {
                var node = nodes.Dequeue();
                if (children.Count == 0) return;
                var left = children.Dequeue();
                if (left.HasValue) {
                    node.left = new TreeNode(left.Value);
                    nodes.Enqueue(node.left);
                }

                if (children.Count == 0) return;
                var right = children.Dequeue();
                if (right.HasValue) {
                    node.right = new TreeNode(right.Value);
                    nodes.Enqueue(node.right);
                };
            }
        }

        [Test]
		public void Test2()
		{
            var src = new int?[] { 10, 5, 15, 3, 7, 13, 18, 1, null, 6 };
            var root = new TreeNode() { val = src.First().Value };

            FillTree(root, new Queue<int?>(src.Skip(1)));
            int low = 6;
			int high = 10;
            int expected = 23;

            var actual = new _938().RangeSumBST(root, low, high);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test1()
        {
            var src = new int?[7] { 10, 5, 15, 3, 7, null, 18 };
            var root = new TreeNode() { val = src.First().Value };

            FillTree(root, new Queue<int?>(src.Skip(1)));
            int low = 7;
            int high = 15;
            int expected = 32;

            var actual = new _938().RangeSumBST(root, low, high);
            Assert.AreEqual(expected, actual);
        }



    }
}
