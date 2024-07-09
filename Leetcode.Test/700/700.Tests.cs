namespace Leetcode.Test
{
	[TestFixture]
	public class _700_Tests
	{

		TreeNode expected;
		TreeNode InitRoot(int[] vals, int val)
		{
			var root = new TreeNode(vals[0]);
			var _q = new Queue<TreeNode>();
			_q.Enqueue(root);
            if (root.val == val)
                expected = root;

            for (int i = 1; i < vals.Length; i++)
			{
				var node = _q.Dequeue();
				node.left = new TreeNode(vals[i]);
				_q.Enqueue(node.left);
                if (node.left.val == val) expected = node.left;

                if (++i < vals.Length)
				{
					node.right = new TreeNode(vals[i]);
					_q.Enqueue(node.right);
                    if (node.right.val == val) expected = node.right;
                }
			}
			return root;
		}

		[Test]
		public void Test1()
		{
			expected = null;
            var val = 2;
			var root = InitRoot([4, 2, 7, 1, 3], val);
			var actual = new _700().SearchBST(root, val);
			Assert.AreEqual(expected, actual);
		}

        [Test]
        public void Test2()
        {
			expected = null;
            var val = 5;
            var root = InitRoot([4, 2, 7, 1, 3], val);
            var actual = new _700().SearchBST(root, val);
            Assert.AreEqual(expected, actual);
        }
    }
}
