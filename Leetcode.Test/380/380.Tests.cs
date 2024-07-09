using static Leetcode.Test._380;

namespace Leetcode.Test
{
	[TestFixture]
	public class _380_Tests
	{

		[Test]
		public void Test1()
		{
            RandomizedSet randomizedSet = new _380.RandomizedSet();
            Assert.IsTrue(randomizedSet.Insert(1)); // Inserts 1 to the set. Returns true as 1 was inserted successfully.
            Assert.IsFalse(randomizedSet.Remove(2)); // Returns false as 2 does not exist in the set.
            Assert.IsTrue(randomizedSet.Insert(2)); // Inserts 2 to the set, returns true. Set now contains [1,2].
            Assert.That(randomizedSet.GetRandom(), Is.AnyOf(1,2)); // getRandom() should return either 1 or 2 randomly.
            Assert.IsTrue(randomizedSet.Remove(1)); // Removes 1 from the set, returns true. Set now contains [2].
            Assert.IsFalse(randomizedSet.Insert(2)); // 2 was already in the set, so return false.
            Assert.That(randomizedSet.GetRandom(), Is.EqualTo(2)); // Since 2 is the only number in the set, getRandom() will always return 2.
        }

        [Test]
        public void Test2()
        {
            RandomizedSet randomizedSet = new _380.RandomizedSet();
            Assert.IsFalse(randomizedSet.Remove(0)); // Returns false as 2 does not exist in the set.
            Assert.IsFalse(randomizedSet.Remove(0)); // Returns false as 2 does not exist in the set.
            Assert.IsTrue(randomizedSet.Insert(0)); // Inserts 2 to the set, returns true. Set now contains [1,2].
            Assert.That(randomizedSet.GetRandom(), Is.AnyOf(0)); // getRandom() should return either 1 or 2 randomly.
            Assert.IsTrue(randomizedSet.Remove(0)); // Removes 1 from the set, returns true. Set now contains [2].
            Assert.IsTrue(randomizedSet.Insert(0)); // 2 was already in the set, so return false.
        }

        [Test]
        public void Test3()
        {
            RandomizedSet randomizedSet = new _380.RandomizedSet();
            Assert.IsTrue(randomizedSet.Insert(0)); // Inserts 2 to the set, returns true. Set now contains [1,2].
            Assert.IsTrue(randomizedSet.Insert(1)); // Inserts 2 to the set, returns true. Set now contains [1,2].
            Assert.IsTrue(randomizedSet.Remove(0)); // Returns false as 2 does not exist in the set.
            Assert.IsTrue(randomizedSet.Insert(2)); 
            Assert.IsTrue(randomizedSet.Remove(1)); // Returns false as 2 does not exist in the set.
            Assert.That(randomizedSet.GetRandom(), Is.AnyOf(2)); // getRandom() should return either 1 or 2 randomly.
        }
    }
}
