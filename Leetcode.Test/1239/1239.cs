using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;

namespace Leetcode.Test
{
    public class _1239
    {
        public int MaxLength(IList<string> arr)
        {
            var lst = new List<HashSet<char>>();

            for (int i = 0; i < arr.Count; i++)
            {
                if (new HashSet<char>(arr[i]).Count() != arr[i].Length)
                    continue;

                var setCnt = lst.Count;
                for (int j = 0; j < setCnt; j++)
                {
                    if (!arr[i].Any(lst[j].Contains))
                    {
                        var hs = new HashSet<char>(lst[j]);
                        foreach (char c in arr[i])
                            hs.Add(c);
                        lst.Add(hs);
                    }
                }
                lst.Add(new HashSet<char>(arr[i]));
            }

            return lst.Count == 0 ? 0 : lst.Max(x => x.Count);
        }

    }
}