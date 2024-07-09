using NUnit.Framework;
using static Leetcode.Test._225;

namespace Leetcode.Test
{
	[TestFixture]
	public class _225_Tests
	{

		[Test]
		public void Test1()
		{
            var myStack = new _225.MyStack();
            myStack.Push(1);
            myStack.Push(2);
            var val1 = myStack.Top(); // return 2
			Assert.AreEqual(2, val1);
            var val2 = myStack.Pop(); // return 2
			Assert.AreEqual(2, val2);
            var isEmpty = myStack.Empty(); // return False
			Assert.AreEqual(false, isEmpty);
		}
	}
}
