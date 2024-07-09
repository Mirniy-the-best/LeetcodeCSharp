using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _872_Tests
	{

		TreeNode InitTree(int?[] nums)
		{
			TreeNode result = null;
			var nodes = new Queue<TreeNode>();
			for (int i = 0; i < nums.Length; i++)
			{
				if (nodes.TryDequeue(out TreeNode parent))
				{
					if (nums[i] != null)
					{
						parent.left = new TreeNode { val = nums[i].Value };
						nodes.Enqueue(parent.left);
					}
					if(++i<nums.Length)
					{
						if (nums[i] !=null)
						{
							parent.right = new TreeNode { val = nums[i].Value };
							nodes.Enqueue(parent.right);
						}
					}
				}
				else
				{
					result = new TreeNode { val = nums[i].Value };
					nodes.Enqueue(result);
				}
			}
			return result;

		}

		[Test]
		public void Test1()
		{
            var root1 = InitTree([3, 5, 1, 6, 2, 9, 8, null, null, 7, 4]);
			var root2 = InitTree([3, 5, 1, 6, 7, 4, 2, null, null, null, null, null, null, 9, 8]);

            var actual = new _872().LeafSimilar(root1, root2);
			Assert.AreEqual(true, actual);
		}

        [Test]
        public void Test2()
        {
            var root1 = InitTree([1, 2, 3]);
            var root2 = InitTree([1, 3, 2]);

            var actual = new _872().LeafSimilar(root1, root2);
            Assert.AreEqual(false, actual);
        }

        [Test]
        public void Test3()
        {
            var root1 = InitTree([3, 5, 1, 6, 7, 4, 2, null, null, null, null, null, null, 9, 11, null, null, 8, 10]);
            var root2 = InitTree([3, 5, 1, 6, 2, 9, 8, null, null, 7, 4]);

            var actual = new _872().LeafSimilar(root1, root2);
            Assert.AreEqual(false, actual);
        }


    }
}
