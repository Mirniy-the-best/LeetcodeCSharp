namespace Leetcode.Test
{
	[TestFixture]
	public class _1457_Tests
	{
		TreeNode InitTree(int?[] values)
		{
			var root = new TreeNode { val = values[0].Value };
			var q = new Queue<TreeNode>();
			q.Enqueue(root);
			for (int i = 1; i < values.Length && q.Count>0; i++)
			{
				var current = q.Dequeue();
				if (values[i] != null)
				{
					current.left = new TreeNode(values[i].Value);
					q.Enqueue(current.left);
				}
				if (++i < values.Length && values[i] != null)
				{
					current.right = new TreeNode(values[i].Value);
					q.Enqueue(current.right);
				}
			}

			return root;
		}


		[Test]
		public void Test1()
		{
			int?[] rootValues = [2, 3, 1, 3, 1, null, 1];
			var root = InitTree(rootValues);
			var expected = 2;

            var actual = new _1457().PseudoPalindromicPaths(root);
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Test2()
		{
			int?[] rootValues =
[9, 5, 4, 5, null, 2, 6, 2, 5, null, 8, 3, 9, 2, 3, 1, 1, null, 4, 5, 4, 2, 2, 6, 4, null, null, 1, 7, null, 5, 4, 7, null, null, 7, null, 1, 5, 6, 1, null, null, null, null, 9, 2, null, 9, 7, 2, 1, null, null, null, 6, null, null, null, null, null, null, null, null, null, 5, null, null, 3, null, null, null, 8, null, 1, null, null, 8, null, null, null, null, 2, null, 8, 7];

            var root = InitTree(rootValues);
			var expected = 1;

            var actual = new _1457().PseudoPalindromicPaths(root);
			Assert.AreEqual(expected, actual);
		}

	}
}
