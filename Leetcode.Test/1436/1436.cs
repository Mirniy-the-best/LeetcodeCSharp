using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _1436
    {
        public string DestCity(IList<IList<string>> paths)
        {
            var node = paths[0];
            do
            {
                var next = paths.FirstOrDefault(x => string.Compare(node[1], x[0], false) == 0);
                if (next == null)
                    return node[1];
                node = next;
            } while (true);
        }
    }
}