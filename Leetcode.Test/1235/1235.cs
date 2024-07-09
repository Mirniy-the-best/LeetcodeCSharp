using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _1235
    {
        class item
        {
            public int startTime { get; set; }
            public int endTime { get; set; }
            public int profit { get; set; }
        }

        public int JobScheduling(int[] startTime, int[] endTime, int[] profit)
        {
            var items = new List<item>(startTime.Length);
            for (int i = 0; i < startTime.Length; i++)
                items.Add(new item { startTime = startTime[i], endTime = endTime[i], profit = profit[i] });
            items = items.OrderBy(x => x.endTime).ToList();

            var profits = new List<KeyValuePair<int, int>>();
            profits.Add(new KeyValuePair<int, int>(0, 0));
            foreach (var item in items)
            {

                int st = profits.ElementAt(Find(profits, item.startTime)).Value;

                var lasrItem = profits.Last();
                if (lasrItem.Key == item.endTime)
                {
                    if (st + item.profit> lasrItem.Value)
                    {
                        profits.Remove(lasrItem);
                        profits.Add(new KeyValuePair<int, int>(lasrItem.Key,st + item.profit));
                    }
                } else
                {
                    int ets = profits.Last().Value;
                    if (st + item.profit > ets)
                        profits.Add(new KeyValuePair<int, int>(item.endTime, st + item.profit));
                }
            }

            return profits.Last().Value;
        }

        private int Find(List<KeyValuePair<int, int>> keys, int target)
        {
            int l = 0; int r = keys.Count - 1;
            while (l <= r)
            {
                var m = l + (r - l) / 2;
                var current = keys.ElementAt(m).Key;
                if (current == target) return m;
                if (current > target) r = m - 1;
                else l = m + 1;
            }
            return r;
        }


    }
}