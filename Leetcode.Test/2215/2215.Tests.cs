using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _2215_Tests
	{

		[Test]
		public void Test1()
		{
			int[] nums1 = [1, 2, 3], nums2 = [2, 4, 6];
			IList<IList<int>> expected = new List<IList<int>>()
			{
                new[] {1,3 },
				new[] {4,6}
			};
            

			var actual = new _2215().FindDifference(nums1, nums2);
			Assert.AreEqual(expected, actual);
		}
	}
}
