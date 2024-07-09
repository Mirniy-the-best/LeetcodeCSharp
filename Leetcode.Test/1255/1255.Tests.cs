namespace Leetcode.Test
{
	[TestFixture]
	public class _1255_Tests
	{

		[Test]
		[TestCase(new[] { "dog", "cat", "dad", "good" }, new[] { "a", "a", "c", "d", "d", "d", "g", "o", "o" }, new[] { 1, 0, 9, 5, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 23)]
		[TestCase(new[] { "xxxz", "ax", "bx", "cx" }, new[] { "z", "a", "b", "c", "x", "x", "x" }, new[] { 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 10 }, 27)]
        [TestCase(new[] { "leetcode" }, new[] { "l", "e", "t", "c", "o", "d" }, new[] { 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 }, 0)]
        public void Test1(string[] words, string[] letters, int[] score, int expected)
		{
			var actual = new _1255().MaxScoreWords(words, letters.Select(x => x[0]).ToArray(), score);
			Assert.AreEqual(expected, actual);
		}
	}
}
