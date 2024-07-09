using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _1306
    {
        public bool CanReach(int[] arr, int start)
        {
            var indeccess = new List<int>(arr.Length);
            var stack = new HashSet<int>(arr.Length);
            stack.Add(start);
            indeccess.Add(start);

            var pointer = 0;

            do
            {
                var cdelta = arr[indeccess[pointer]];
                var lp = indeccess[pointer] - cdelta;
                if (lp >= 0)
                {
                    if (arr[lp] == 0) return true;
                    if (!stack.Contains(lp))
                    {
                        stack.Add(lp);
                        indeccess.Add(lp);
                    }
                }
                var rp = indeccess[pointer] + cdelta;
                if (rp < arr.Length)
                {
                    if (arr[rp] == 0) return true;
                    if (!stack.Contains(rp))
                    {
                        stack.Add(rp);
                        indeccess.Add(rp);
                    }
                }
                pointer++;
            } while (pointer < indeccess.Count);

            return false;
        }
    }
}