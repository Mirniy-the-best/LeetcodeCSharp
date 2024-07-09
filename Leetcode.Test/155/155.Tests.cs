using static Leetcode.Test._155;

namespace Leetcode.Test
{
	[TestFixture]
	public class _155_Tests
	{

		[Test]
		public void Test1()
		{
            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            Assert.AreEqual(-3, minStack.GetMin()); // return -3
            minStack.Pop();
            Assert.AreEqual(0, minStack.Top());    // return 0
            Assert.AreEqual(-2, minStack.GetMin());
        }
	}
}
