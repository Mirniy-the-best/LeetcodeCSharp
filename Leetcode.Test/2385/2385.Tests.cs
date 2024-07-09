namespace Leetcode.Test
{
	[TestFixture]
	public class _2385_Tests
	{
        private TreeNode initTree(int?[] values)
        {
            var root = new TreeNode(values[0].Value);
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            for (int i = 1; i < values.Length; i++)
            {
                var node = queue.Dequeue();
                {
                    if (values[i] != null)
                    {
                        node.left = new TreeNode(values[i].Value);
                        queue.Enqueue(node.left);
                    }
                    if (++i < values.Length && values[i] != null)
                    {
                        node.right = new TreeNode(values[i].Value);
                        queue.Enqueue(node.right);
                    }
                }
            }

            return root;
        }

        [Test]
		public void Test1()
		{
			var root = initTree([1, 5, 3, null, 4, 10, 6, 9, 2]);
			int start = 3;
			int expected = 4;

            var actual = new _2385().AmountOfTime(root, start);
			Assert.AreEqual(expected, actual);
		}

        [Test]
        public void TestOneNode()
        {
            var root = initTree([1]);
            int start = 1;
            int expected = 0;

            var actual = new _2385().AmountOfTime(root, start);
            Assert.AreEqual(expected, actual);
        }

    }
}
