using NUnit.Framework;

namespace Leetcode.Test.t2353
{
	[TestFixture]
	public class _2353_Tests
	{

		[Test]
		public void Test1()
		{
            /**
 * Your FoodRatings object will be instantiated and called as such:
 * FoodRatings obj = new FoodRatings(foods, cuisines, ratings);
 * obj.ChangeRating(food,newRating);
 * string param_2 = obj.HighestRated(cuisine);
 */
            string[] foods = ["kimchi", "miso", "sushi", "moussaka", "ramen", "bulgogi"];
            string[] cuisines = ["korean", "japanese", "japanese", "greek", "japanese", "korean"];
            int[] ratings = [9, 12, 8, 15, 14, 7];
            FoodRatings foodRatings = new FoodRatings(foods, cuisines, ratings);

            Assert.AreEqual("kimchi", foodRatings.HighestRated("korean"));
            Assert.AreEqual("ramen", foodRatings.HighestRated("japanese"));
            foodRatings.ChangeRating("sushi", 16);
            Assert.AreEqual("sushi", foodRatings.HighestRated("japanese"));
            foodRatings.ChangeRating("ramen", 16);
            Assert.AreEqual("ramen", foodRatings.HighestRated("japanese"));

            //var actual = new _0().FindSpecialInteger(nums);
            //Assert.AreEqual(expected, actual);

        }
	}
}
