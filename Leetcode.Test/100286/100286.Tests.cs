namespace Leetcode.Test
{
	[TestFixture]
	public class _100286_Tests
    {

		[Test]
		public void Test1()
		{
            char[][] temp = [['B', 'W', 'B'], ['W', 'B', 'W'], ['B', 'W', 'B']];

            var actual = new _100286().CanMakeSquare(temp);
			Assert.AreEqual(false, actual);
		}

        [Test]
        public void Test2()
        {
            char[][] temp = [['B', 'W', 'B'], ['B', 'W', 'B'], ['W', 'B', 'W']];

            var actual = new _100286().CanMakeSquare(temp);
            Assert.AreEqual(false, actual);
        }

        [Test]
        public void Test3()
        {
            char[][] temp = [['B', 'W', 'B'], ['B', 'W', 'W'], ['B', 'W', 'B']];

            var actual = new _100286().CanMakeSquare(temp);
            Assert.AreEqual(true, actual);
        }

        [Test]
        public void Test4()
        {
            char[][] temp = [['B', 'W', 'B'], ['B', 'W', 'W'], ['B', 'W', 'W']];

            var actual = new _100286().CanMakeSquare(temp);
            Assert.AreEqual(true, actual);
        }

    }
}
