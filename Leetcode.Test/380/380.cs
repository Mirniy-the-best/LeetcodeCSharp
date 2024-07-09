using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Leetcode.Test
{
    public class _380
    {
        public class RandomizedSet
        {
            List<int> _nums = new List<int>();
            Dictionary<int, int> _index = new Dictionary<int, int>();

            Random _random = new Random(DateTime.Now.Microsecond);
            public RandomizedSet()
            {
            }

            public bool Insert(int val)
            {
                if (_index.ContainsKey(val))
                    return false;

                if (_nums.Count > _index.Count)
                {
                    _nums[_index.Count] = val;
                    _index.Add(val, _index.Count);
                    return true;
                }

                _index.Add(val, _nums.Count);
                _nums.Add(val);
                return true;
            }

            public bool Remove(int val)
            {
                if (_index.TryGetValue(val, out int valPosition))
                {
                    _nums[valPosition] = _nums[_index.Count-1];
                    _index[_nums[valPosition]] = valPosition;
                    _index.Remove(val);

                    return true;
                }
                return false;
            }

            public int GetRandom()
            {
                var randomNum = _random.Next(_index.Count);
                return _nums[randomNum];
            }
        }

    }
}