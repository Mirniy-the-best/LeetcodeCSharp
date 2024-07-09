using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _1207
    {
        public bool UniqueOccurrences(int[] arr)
        {
            var index = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
                if (index.ContainsKey(arr[i])) index[arr[i]]++;
                else index.Add(arr[i], 1);

            var set = new HashSet<int>();
            foreach (int i in index.Values)
                if (set.Contains(i)) return false;
                else set.Add(i);

            return true;
        }

    }
}