using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test.t2353
{
    public class FoodRatings
    {
        class node: IComparable<node>
        {
            public string food { get; set; }
            public int rating{ get; set; }

            public int CompareTo(node? other)
            {
                if (rating < other.rating) return 1;
                if (rating > other.rating) return -1;
                return String.Compare(food, other.food);
            }
        }

        Dictionary<string, int> foodRates = new Dictionary<string, int>();
        Dictionary<string, string> fclist = new Dictionary<string, string>();
        SortedDictionary<string, PriorityQueue<node, node>> data = new SortedDictionary<string, PriorityQueue<node, node>>();
        public FoodRatings(string[] foods, string[] cuisines, int[] ratings)
        {
            for (int i = 0; i < foods.Length; i++)
            {
                foodRates.Add(foods[i], ratings[i]);
                fclist.Add(foods[i], cuisines[i]);
                var cn = new node { food = foods[i], rating = ratings[i] };
                if (!data.ContainsKey(cuisines[i]))
                    data.Add(cuisines[i], new PriorityQueue<node, node>());
                data[cuisines[i]].Enqueue(cn, cn);
            }
        }

        public void ChangeRating(string food, int newRating)
        {
            foodRates[food] = newRating;
            var node = new node { food = food, rating = newRating };
            data[fclist[food]].Enqueue(node, node);
        }

        public string HighestRated(string cuisine)
        {
            node result;
            do {
                result = data[cuisine].Peek();
                if(result.rating != foodRates[result.food])
                    data[cuisine].Dequeue();
                else
                    return result.food;
            } while (true);
        }
    }

    /**
     * Your FoodRatings object will be instantiated and called as such:
     * FoodRatings obj = new FoodRatings(foods, cuisines, ratings);
     * obj.ChangeRating(food,newRating);
     * string param_2 = obj.HighestRated(cuisine);
     */
}